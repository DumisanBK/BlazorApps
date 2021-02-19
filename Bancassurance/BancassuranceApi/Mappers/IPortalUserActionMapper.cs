using BancassuranceApi.ViewModels;
using BancassuranceLib.Models;

namespace BancassuranceApi.Mappers
{
    public interface IPortalUserActionMapper
    {
        PortalUserActions Map(string entityId, string action, string username);
        PortalUserActions Map(string entityId, string action, SessionBridgeVm sessionBridge);
    }
}