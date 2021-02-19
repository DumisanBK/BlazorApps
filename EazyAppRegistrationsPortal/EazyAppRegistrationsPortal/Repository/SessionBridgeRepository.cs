using EazyAppRegistrationsPortal.Models;
using EazyAppRegistrationsPortal.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EazyAppRegistrationsPortal.Repository
{
    public class SessionBridgeRepository : ISessionBridgeRepository
    {
        private readonly SmartAppContext _smartAppContext;

        public SessionBridgeRepository(SmartAppContext smartAppContext)
        {
            _smartAppContext = smartAppContext;
        }

        public async Task<PortalUserSessionBridge> GetSessionBridgeAsync(string id)
        {
            var sessionBridge = await _smartAppContext.PortalUserSessionBridge
                .SingleOrDefaultAsync(b => b.SessionId == id && b.Used == false);

            if (sessionBridge == null)
                return null;

            sessionBridge.Used = true;
            
            _smartAppContext.Entry(sessionBridge).State = EntityState.Modified;
            await _smartAppContext.SaveChangesAsync();

            return sessionBridge;
        }

        public async Task<List<PortalUserSessionBridge>> GetSessionBridgesAsync(Func<PortalUserSessionBridge, bool> queryCriterial)
        {
            var sessionBridges = await _smartAppContext.PortalUserSessionBridge
                .Where(b => queryCriterial.Invoke(b))
                .Select(b => b)
                .ToListAsync();

            return sessionBridges;
        }
    }
}
