using BancassuranceLib.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public interface IUnsubscriptionService
    {
        Task<bool> AuthorizeRequestAsync(long memberId, string voider);
        Task<bool> DenyRequestAsync(long memberId, string voider);
        Task<List<UnSubscriptionRequest>> GetPendingUnsubscriptionsAsync();
        Task<bool> RequestUnSubscriptionAsync(long memberId, string requester, string reason);
    }
}