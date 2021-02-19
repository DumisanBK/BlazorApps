using System.Threading.Tasks;

namespace EazyAppRegistrationsPortal.Utils
{
    public interface IPageAccessChecker
    {
        Task<bool> HasAccess(string sessionId, string page);
    }
}