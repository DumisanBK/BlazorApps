using EazyMobileRegPortal.Models;
using EazyMobileRegPortal.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EazyMobileRegPortal.Repository
{
    public class SessionBridgeRepository : ISessionBridgeRepository
    {
        private readonly emailbankingContext _emailBankingContext;

        public SessionBridgeRepository(emailbankingContext emailBankingContext)
        {
            _emailBankingContext = emailBankingContext;
        }

        public async Task<PortalUserSessionBridge> GetSessionBridgeAsync(string id)
        {
            var sessionBridge = await _emailBankingContext.PortalUserSessionBridge
                .SingleOrDefaultAsync(b => b.SessionId == id && b.Used == false);

            if (sessionBridge == null) return null;

            sessionBridge.Used = true;

            _emailBankingContext.Entry(sessionBridge).State = EntityState.Modified;
            await _emailBankingContext.SaveChangesAsync();

            return sessionBridge;
        }

        public async Task<List<PortalUserSessionBridge>> GetSessionBridgesAsync(Func<PortalUserSessionBridge, bool> queryCriterial)
        {
            var sessionBridges = await _emailBankingContext.PortalUserSessionBridge
                .Where(b => queryCriterial.Invoke(b))
                .Select(b => b)
                .ToListAsync();

            return sessionBridges;
        }
    }
}
