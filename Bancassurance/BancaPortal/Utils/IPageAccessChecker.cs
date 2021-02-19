using System.Threading.Tasks;

namespace BancaPortal.Utils
{
    public interface IPageAccessChecker
    {
        Task<bool> HasAccess(string page, string sessionId);
    }
}