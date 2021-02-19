using BancassuranceApi.ViewModels;
using BancassuranceLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public interface ISessionBridgeService
    {
        Task<SessionBridgeVm> GetSessionBridgeAsync(string guid, bool forfeitKey = false);
        Task<List<SessionBridgeVm>> GetSessionBridgesAsync(Expression<Func<PortalUserSessionBridge, bool>> filter = null, 
            Func<IQueryable<PortalUserSessionBridge>, IOrderedQueryable<PortalUserSessionBridge>> orderBy = null);
        Task<bool> UpdateSessionBridgeAsync(SessionBridgeVm sessionBridgeVm);
        Task<bool> UpdateSessionBridgeAsync(PortalUserSessionBridge sessionBridge);
    }
}