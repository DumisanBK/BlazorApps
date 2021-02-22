using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EazyMobileRegPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace EazyMobileRegPortal.Repository
{
    public class TbSelfRegistrationRepository : ITbSelfRegistrationRepository
    {
        private readonly emailbankingContext _emailbankingContext;

        public TbSelfRegistrationRepository(emailbankingContext emailbankingContext)
        {
            _emailbankingContext = emailbankingContext;
        }

        public async Task<TbSelfRegistration> GetCustomerAsync(string customerNumber)
        {
            var customer = await _emailbankingContext.TbSelfRegistration
                .SingleOrDefaultAsync(regInfo => regInfo.AcCustomerNumber == customerNumber);

            return customer;
        }

        public async Task<List<TbSelfRegistration>> GetCustomersAsync()
        {
            var customers = await _emailbankingContext.TbSelfRegistration.ToListAsync();

            return customers;
        }
    }

}
