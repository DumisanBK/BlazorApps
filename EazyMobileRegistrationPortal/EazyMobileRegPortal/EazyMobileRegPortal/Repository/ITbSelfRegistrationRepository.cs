using System.Collections.Generic;
using System.Threading.Tasks;
using EazyMobileRegPortal.Models;

namespace EazyMobileRegPortal.Repository
{
    public interface ITbSelfRegistrationRepository
    {
        Task<TbSelfRegistration> GetCustomerAsync(string customerNumber);
        Task<List<TbSelfRegistration>> GetCustomersAsync();
    }
}