using EazyMobileRegPortal.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EazyMobileRegPortal.Repository
{
    public interface IPageAccessRepository
    {
        Task<List<PageAccess>> GetAllAsync();
        Task<PageAccess> GetAsync(int roleId, bool access, string page);
    }
}