using BancassuranceApi.Resources;
using BancassuranceApi.ViewModels;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public interface IT24AccountService
    {
        bool CanFetchAccount();
        JsonResult<AccountInfo> DoesAccountExist(string account);
        Task<CustomerMessage> GetCustomerDetailsAsync(string accountNumber);
        JsonResult<CustomerInformation> GetCustomerDetails(string customerNumber);
    }
}