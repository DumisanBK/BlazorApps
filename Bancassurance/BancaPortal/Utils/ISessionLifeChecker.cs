namespace BancaPortal.Utils
{
    public interface ISessionLifeChecker
    {
        bool IsExpired(string sessionId);
    }
}