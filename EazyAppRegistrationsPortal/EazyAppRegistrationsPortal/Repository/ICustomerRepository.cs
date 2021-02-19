using System.Collections.Generic;
using System.Threading.Tasks;
using EazyAppRegistrationsPortal.Models;

namespace EazyAppRegistrationsPortal.Repository
{
    public interface ICustomerRepository
    {
        Task<Customers> GetCustomerAsync(string customerNumber);
        Task<List<Customers>> GetCustomersAsync();
    }
}