using EazyAppRegistrationsPortal.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EazyAppRegistrationsPortal.Repository
{
    public interface IUserActionsRepository
    {
        Task<List<PortalUserActions>> GetUserActionsAsync();
        Task<List<PortalUserActions>> GetUserActionsAsync(string username);
    }
}