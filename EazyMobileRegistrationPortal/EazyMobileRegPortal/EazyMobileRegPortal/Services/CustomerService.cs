using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EazyMobileRegPortal.Data;
using EazyMobileRegPortal.Mapper;
using EazyMobileRegPortal.Models;
using EazyMobileRegPortal.Repository;
using EazyMobileRegPortal.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace EazyMobileRegPortal.Services
{
    public class CustomerService
    {
        private readonly IMapper _mapper;
        private readonly emailbankingContext _emailbankingContext;
        private readonly ITbSelfRegistrationRepository _tbSelfRegistationRepository;
        private readonly ISessionBridgeVmManager _sessionBridgeVmManager;
        private readonly PortalUserActionMapper _portalUserActionMapper;

        public CustomerService(IMapper mapper, emailbankingContext emailbankingContext,
            ITbSelfRegistrationRepository tbSelfRegistationRepository,
            ISessionBridgeVmManager sessionBridgeVmManager,
            PortalUserActionMapper portalUserActionMapper)
        {
            _mapper = mapper;
            _emailbankingContext = emailbankingContext;            
            _sessionBridgeVmManager = sessionBridgeVmManager;
            _portalUserActionMapper = portalUserActionMapper;
            _tbSelfRegistationRepository = tbSelfRegistationRepository;
        }

        public async Task<List<TbSelfRegistrationVm>> GetUncheckedCustomers()
        {
            var customers = (await _tbSelfRegistationRepository.GetCustomersAsync())
                .Where(c => !c.Checked)
                .Where(c => !c.Approved)
                .Where(c => !c.Denied)
                .Select(c => _mapper.Map<TbSelfRegistrationVm>(c))
                .ToList();

            return customers;
        }

        public async Task<List<TbSelfRegistrationVm>> GetCheckedCustomers()
        {
            var customers = (await _tbSelfRegistationRepository.GetCustomersAsync())
                .Where(c => c.Checked)
                .Where(c => !c.Approved)
                .Where(c => !c.Denied)
                .Select(c => _mapper.Map<TbSelfRegistrationVm>(c))
                .ToList();

            return customers;
        }

        public async Task<List<TbSelfRegistrationVm>> GetApprovedCustomers()
        {
            var customers = (await _tbSelfRegistationRepository.GetCustomersAsync())
                .Where(c => c.Checked)
                .Where(c => c.Approved)
                .Where(c => !c.Denied)
                .Select(c => _mapper.Map<TbSelfRegistrationVm>(c))
                .ToList();

            return customers;
        }

        public async Task<List<TbSelfRegistrationVm>> GetDeniedCustomersAsync()
        {
            var customers = (await _tbSelfRegistationRepository.GetCustomersAsync())
                .Where(c => !c.Checked)
                .Where(c => !c.Approved)
                .Where(c => c.Denied)
                .Select(c => _mapper.Map<TbSelfRegistrationVm>(c))
                .ToList();

            return customers;
        }

        public async Task<bool> CheckCustomerAsync(string sessionId, string customerNumber)
        {
            var customer = await _tbSelfRegistationRepository.GetCustomerAsync(customerNumber);

            if (customer == null)
            {
                return false;
            }

            var sessionBridge = _sessionBridgeVmManager.GetFromBasket(sessionId);

            if (sessionBridge == null)
            {
                return false;
            }

            var userAction = _portalUserActionMapper.Map(customerNumber, "checked customer", sessionBridge);

            customer.Checked = true;
            customer.AcStatus = "Checked";
            customer.CheckedBy = sessionBridge.FullName;
            customer.CheckedDate = DateTime.Now;

            _emailbankingContext.PortalUserActions.Add(userAction);

            _emailbankingContext.Entry(customer).State = EntityState.Modified;
            
            await _emailbankingContext.SaveChangesAsync();

            return true;

        }

        public async Task<bool> ApproveCustomerAsync(string sessionId, string customerNumber)
        {
            var customer = await _tbSelfRegistationRepository.GetCustomerAsync(customerNumber);

            if (customer == null)
            {
                return false;
            }

            var sessionBridge = _sessionBridgeVmManager.GetFromBasket(sessionId);
            if (sessionBridge == null)
            {
                return false;
            }

            var userAction = _portalUserActionMapper.Map(customerNumber, "approved customer", sessionBridge);

            customer.Approved = true;
            customer.AcStatus = "Approved";
            customer.ApprovedBy = sessionBridge.FullName;
            customer.ApprovedDate = DateTime.Now;

            _emailbankingContext.PortalUserActions.Add(userAction);

            _emailbankingContext.Entry(customer).State = EntityState.Modified;

            await _emailbankingContext.SaveChangesAsync();

            return true;

        }

        public async Task<bool> DenyCustomerAsync(string sessionId, string customerNumber)
        {
            var customer = await _tbSelfRegistationRepository.GetCustomerAsync(customerNumber);
            if (customer == null)
            {
                return false;
            }

            var sessionBridge = _sessionBridgeVmManager.GetFromBasket(sessionId);
            if (sessionBridge == null)
            {
                return false;
            }

            var userAction = _portalUserActionMapper.Map(customerNumber, "denied customer", sessionBridge);

            customer.Checked = false;
            customer.Denied = true;
            customer.Approved = false;
            customer.AcStatus = "Denied";
            customer.DeniedBy = sessionBridge.FullName;
            customer.DeniedDate = DateTime.Now;

            _emailbankingContext.PortalUserActions.Add(userAction);

            _emailbankingContext.Entry(customer).State = EntityState.Modified;

            await _emailbankingContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> RollBackInitializeAsync(string sessionId, string customerNumber)
        {
            var customer = await _tbSelfRegistationRepository.GetCustomerAsync(customerNumber);
            if (customer == null)
            {
                return false;
            }

            var sessionBridge = _sessionBridgeVmManager.GetFromBasket(sessionId);
            if (sessionBridge == null)
            {
                return false;
            }

            var userAction = _portalUserActionMapper.Map(customerNumber, "rolled back checked customer", sessionBridge);

            customer.Checked = false;
            customer.Approved = false;
            customer.Denied = false;
            customer.AcStatus = "pending";
            customer.CheckedBy = sessionBridge.FullName;

            _emailbankingContext.PortalUserActions.Add(userAction);

            _emailbankingContext.Entry(customer).State = EntityState.Modified;

            await _emailbankingContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> RollBackApprovedCustomerAsync(string sessionId, string customerNumber)
        {
            var customer = await _tbSelfRegistationRepository.GetCustomerAsync(customerNumber);
            if (customer == null)
            {
                return false;
            }

            var sessionBridge = _sessionBridgeVmManager.GetFromBasket(sessionId);
            if (sessionBridge == null)
            {
                return false;
            }

            var userAction = _portalUserActionMapper.Map(customerNumber, "rolled back approved customer", sessionBridge);

            customer.Checked = true;
            customer.Approved = false;
            customer.Denied = false;
            customer.AcStatus = "Checked";
            customer.ApprovedBy = sessionBridge.FullName;

            _emailbankingContext.PortalUserActions.Add(userAction);

            _emailbankingContext.Entry(customer).State = EntityState.Modified;

            await _emailbankingContext.SaveChangesAsync();

            return true;
        }

    }
}