namespace BancassuranceApi.Services
{
    public interface ISessionChecker
    {
        bool IsSessionMissing(string sessionId);
    }
}