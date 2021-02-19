using BancassuranceApi.ViewModels;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public interface IPortalUserActionsService
    {
        Task<bool> AddAsync(SessionBridgeVm sessionBridgeVm, string action, string entityId);
    }
}