using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EazyAppRegistrationsPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace EazyAppRegistrationsPortal.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly SmartAppContext _smartAppContext;
        
        public CustomerRepository(SmartAppContext smartAppContext)
        {
            _smartAppContext = smartAppContext;
        }

        public async Task<Customers> GetCustomerAsync(string customerNumber)
        {
            var customer = await _smartAppContext.Customers.FindAsync(customerNumber);

            return customer;
        }

        public async Task<List<Customers>> GetCustomersAsync()
        {
            var customers = await _smartAppContext.Customers.ToListAsync();

            return customers;
        }
    }
}
