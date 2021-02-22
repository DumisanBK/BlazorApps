using EazyMobileRegPortal.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EazyMobileRegPortal.Repository
{
    public class PageAccessRepository : IPageAccessRepository
    {
        private readonly emailbankingContext _emailBankingContext;

        public PageAccessRepository(emailbankingContext emailBankingContext)
        {           
            _emailBankingContext = emailBankingContext;
        }

        public Task<List<PageAccess>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PageAccess> GetAsync(int roleId, bool access, string page)
        {
            throw new NotImplementedException();
        }
    }
}
