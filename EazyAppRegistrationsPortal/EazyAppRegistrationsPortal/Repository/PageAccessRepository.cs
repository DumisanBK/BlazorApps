using EazyAppRegistrationsPortal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EazyAppRegistrationsPortal.Repository
{
    public class PageAccessRepository : IPageAccessRepository
    {
        private readonly SmartAppContext _smartAppContext;

        public PageAccessRepository(SmartAppContext smartAppContext)
        {           
            _smartAppContext = smartAppContext;
        }

        public async Task<List<PageAccess>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<PageAccess> GetAsync(int roleId, bool access, string page)
        {
            throw new NotImplementedException();
        }
    }
}
