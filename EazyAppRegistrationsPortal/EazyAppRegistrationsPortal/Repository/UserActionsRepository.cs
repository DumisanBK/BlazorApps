using EazyAppRegistrationsPortal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EazyAppRegistrationsPortal.Repository
{
    public class UserActionsRepository : IUserActionsRepository
    {
        private readonly SmartAppContext _smartAppContext;

        public UserActionsRepository(SmartAppContext smartAppContext)
        {
            _smartAppContext = smartAppContext;
        }

        public async Task<List<PortalUserActions>> GetUserActionsAsync()
        {
            var actions = await _smartAppContext.PortalUserActions.ToListAsync();

            return actions;
        }

        public async Task<List<PortalUserActions>> GetUserActionsAsync(string username)
        {
            var actions = await _smartAppContext.PortalUserActions
                .Where(a => a.Username == username)
                .ToListAsync();

            return actions;
        }
    }
}
