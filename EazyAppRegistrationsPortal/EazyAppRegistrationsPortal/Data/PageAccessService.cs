using AutoMapper;
using EazyAppRegistrationsPortal.Models;
using EazyAppRegistrationsPortal.Repository;
using EazyAppRegistrationsPortal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EazyAppRegistrationsPortal.Data
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
