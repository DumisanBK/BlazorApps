namespace EazyAppRegistrationsPortal.Data
{
    public class SessionChecker : ISessionChecker
    {
        private readonly ISessionBridgeVmManager _sessionBridgeVmManager;

        public SessionChecker(ISessionBridgeVmManager sessionBridgeVmManager)
        {
            _sessionBridgeVmManager = sessionBridgeVmManager;
        }

        public bool IsSessionMissing(string sessionId)
        {
            var sessionBridge = _sessionBridgeVmManager.GetFromBasket(sessionId);

            return sessionBridge == null;
        }
    }
}
