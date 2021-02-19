using BancassuranceApi.ViewModels;

namespace BancassuranceApi.Services
{
    public interface ISessionBridgeVmManager
    {
        SessionBridgeVm GetFromBasket(string sessionId);
        void PutInBasket(SessionBridgeVm sessionBridgeVm);
        bool AlreadyAdded(string sessionId);
    }
}