namespace EazyMobileRegPortal.Data
{
    public interface ISessionChecker
    {
        bool IsSessionMissing(string sessionId);
    }
}