using EazyMobileRegPortal.ViewModels;

namespace EazyMobileRegPortal.Data
{
    public interface ISessionBridgeVmManager
    {
        SessionBridgeVm GetFromBasket(string sessionId);
        void PutInBasket(SessionBridgeVm sessionBridgeVm);
        bool AlreadyAdded(string sessionId);
    }
}