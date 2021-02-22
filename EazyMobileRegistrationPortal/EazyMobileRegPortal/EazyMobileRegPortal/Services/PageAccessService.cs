using AutoMapper;
using EazyMobileRegPortal.Models;
using EazyMobileRegPortal.Repository;
using EazyMobileRegPortal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EazyMobileRegPortal.Data
{
    public class PageAccessService
    {
        private readonly IMapper _mapper;        
        private readonly IPageAccessRepository _pageAccessRepository;

        public PageAccessService(IMapper mapper, IPageAccessRepository pageAccessRepository)
        {
            _mapper = mapper;
            _pageAccessRepository = pageAccessRepository;
        }

        public async Task<PageAccessVm> GetPageAccessAsync(int roleId, bool access, string page)
        {
            PageAccess pageAccess = await _pageAccessRepository.GetAsync(roleId, access, page);

            if (pageAccess == null)
                return null;

            return _mapper.Map<PageAccessVm>(pageAccess);
        }
    }
}
