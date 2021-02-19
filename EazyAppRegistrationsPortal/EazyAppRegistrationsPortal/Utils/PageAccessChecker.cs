using EazyAppRegistrationsPortal.Data;
using EazyAppRegistrationsPortal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EazyAppRegistrationsPortal.Utils
{
    public class PageAccessChecker : IPageAccessChecker
    {
        private readonly PageAccessService _pageAccessService;
        private readonly ISessionBridgeVmManager _sessionBridgeVmManager;

        public PageAccessChecker(PageAccessService pageAccessService, ISessionBridgeVmManager sessionBridgeVmManager)
        {
            _pageAccessService = pageAccessService;
            _sessionBridgeVmManager = sessionBridgeVmManager;
        }

        public async Task<bool> HasAccess(string sessionId, string page)
        {
            var sessionBridgeVm = _sessionBridgeVmManager.GetFromBasket(sessionId);
            if (sessionBridgeVm == null)
                return false;

            var pageAccess = await _pageAccessService.GetPageAccessAsync(sessionBridgeVm.RoleId, true, page);

            bool access = pageAccess != null;

            return access;
        }

    }
}
