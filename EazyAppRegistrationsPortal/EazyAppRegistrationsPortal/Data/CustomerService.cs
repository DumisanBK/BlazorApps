using EazyAppRegistrationsPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EazyAppRegistrationsPortal.Repository;
using EazyAppRegistrationsPortal.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace EazyAppRegistrationsPortal.Data
{
    public class CustomerService
    {
        private readonly IMapper _mapper;
        private readonly SmartAppContext _smartAppContext;
        private readonly ICustomerRepository _customerRepository;
        private readonly ISessionBridgeVmManager _sessionBridgeVmManager;

        public CustomerService(IMapper mapper, SmartAppContext smartAppContext, 
            ICustomerRepository customerRepository,
            ISessionBridgeVmManager sessionBridgeVmManager)
        {
            _mapper = mapper;
            _smartAppContext = smartAppContext;
            _customerRepository = customerRepository;
            _sessionBridgeVmManager = sessionBridgeVmManager;
        }

        public async Task<List<CustomerVm>> GetUncheckedCustomers()
        {
            var customers = (await _customerRepository.GetCustomersAsync())
                .Where(c => !c.Checked)
                .Where(c => !c.Approved)
                 .Where(c => !c.Denied)
                 .Select(c => _mapper.Map<CustomerVm>(c))
                 .ToList();

            return customers;
        }

        public async Task<List<CustomerVm>> GetCheckedCustomers()
        {
            var customers = (await _customerRepository.GetCustomersAsync())
                .Where(c => c.Checked)
                .Where(c => !c.Approved)
                .Where(c => !c.Denied)
                .Select(c => _mapper.Map<CustomerVm>(c))
                .ToList();

            return customers;
        }

        public async Task<List<CustomerVm>> GetApprovedCustomers()
        {
            var customers = (await _customerRepository.GetCustomersAsync())
                .Where(c => c.Checked)
                .Where(c => c.Approved)
                .Where(c => !c.Denied)
                .Select(c => _mapper.Map<CustomerVm>(c))
                .ToList();

            return customers;
        }

        public async Task<CustomerVm> GetCustomerAsync(string customerNumber)
        {
            var customer = await _customerRepository.GetCustomerAsync(customerNumber);

            if (customer == null)
                return null;

            return _mapper.Map<CustomerVm>(customer);
        }

        public async Task<bool> CheckCustomer(string sessionId, string customerNumber)
        {
            var customer = await _customerRepository.GetCustomerAsync(customerNumber);

            if (customer == null)
            {
                return false;
            }

            var sessionBridge = _sessionBridgeVmManager.GetFromBasket(sessionId);
            if (sessionBridge == null)
            {
                return false;
            }

            var userAction = _mapper.Map<PortalUserActions>(sessionBridge);
            userAction.Id = 0;
            userAction.Action = "Checked a customer";
            userAction.DateConducted = DateTime.Now;
            userAction.EntityId = customerNumber;

            customer.Checked = true;
            customer.CheckedBy = sessionBridge.FullName;
            customer.DateChecked = DateTime.Now;

            _smartAppContext.PortalUserActions.Add(userAction);
            _smartAppContext.Entry(customer).State = EntityState.Modified;
            await _smartAppContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> RollBackCheck(string sessionId, string customerNumber)
        {
            var customer = await _customerRepository.GetCustomerAsync(customerNumber);

            if (customer == null)
            {
                return false;
            }

            var sessionBridge = _sessionBridgeVmManager.GetFromBasket(sessionId);
            if (sessionBridge == null)
            {
                return false;
            }

            var userAction = _mapper.Map<PortalUserActions>(sessionBridge);
            userAction.Id = 0;
            userAction.Action = "Rolled back a checked customer";
            userAction.DateConducted = DateTime.Now;
            userAction.EntityId = customerNumber;

            customer.Checked = false;

            _smartAppContext.PortalUserActions.Add(userAction);
            _smartAppContext.Entry(customer).State = EntityState.Modified;
            await _smartAppContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ApproveCustomer(string sessionId, string customerNumber)
        {
            var customer = await _customerRepository.GetCustomerAsync(customerNumber);

            if (customer == null)
            {
                return false;
            }

            var sessionBridge = _sessionBridgeVmManager.GetFromBasket(sessionId);
            if (sessionBridge == null)
            {
                return false;
            }

            var userAction = _mapper.Map<PortalUserActions>(sessionBridge);
            userAction.Id = 0;
            userAction.Action = "Approved a customer";
            userAction.DateConducted = DateTime.Now;
            userAction.EntityId = customerNumber;

            customer.Approved = true;
            customer.ApprovedBy = sessionBridge.FullName;
            customer.DateApproved = DateTime.Now;

            _smartAppContext.PortalUserActions.Add(userAction);
            _smartAppContext.Entry(customer).State = EntityState.Modified;
            await _smartAppContext.SaveChangesAsync();
               
            return true;
        }

        public async Task<bool> RollBackApproval(string sessionId, string customerNumber)
        {
            var customer = await _customerRepository.GetCustomerAsync(customerNumber);

            if (customer == null)
            {
                return false;
            }

            var sessionBridge = _sessionBridgeVmManager.GetFromBasket(sessionId);
            if (sessionBridge == null)
            {
                return false;
            }

            var userAction = _mapper.Map<PortalUserActions>(sessionBridge);
            userAction.Id = 0;
            userAction.Action = "Rolled back an approved customer";
            userAction.DateConducted = DateTime.Now;
            userAction.EntityId = customerNumber;

            customer.Approved = false;

            _smartAppContext.PortalUserActions.Add(userAction);
            _smartAppContext.Entry(customer).State = EntityState.Modified;
            await _smartAppContext.SaveChangesAsync();

            return true;
        }
    }
}
