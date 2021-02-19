namespace EazyAppRegistrationsPortal.Data
{
    public interface ISessionChecker
    {
        bool IsSessionMissing(string sessionId);
    }
}