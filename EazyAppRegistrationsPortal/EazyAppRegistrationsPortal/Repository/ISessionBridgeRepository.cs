using EazyAppRegistrationsPortal.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EazyAppRegistrationsPortal.Repository
{
    public interface ISessionBridgeRepository
    {
        Task<PortalUserSessionBridge> GetSessionBridgeAsync(string id);
        Task<List<PortalUserSessionBridge>> GetSessionBridgesAsync(Func<PortalUserSessionBridge, bool> queryCriterial);
    }
}