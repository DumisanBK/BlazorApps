using BancassuranceApi.Services;
using BancassuranceApi.Utils;
using BancassuranceLib.Models;
using BancassuranceLib.Repository;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BancaPortal.Utils
{
    public class PageAccessChecker : IPageAccessChecker
    {        
        private readonly IUnitOfWorkRepo _unitOfWorkRepo;
        private readonly ISessionBridgeVmManager _sessionBridgeVmManager;

        public PageAccessChecker(IUnitOfWorkRepo unitOfWorkRepo, ISessionBridgeVmManager sessionBridgeVmManager)
        {
            _unitOfWorkRepo = unitOfWorkRepo;
            _sessionBridgeVmManager = sessionBridgeVmManager;
        }

        public async Task<bool> HasAccess(string page, string sessionId)
        {
            var sessionBridgeVm = _sessionBridgeVmManager.GetFromBasket(sessionId);
            if (sessionBridgeVm == null) return false;            

            var pageAccess = await _unitOfWorkRepo.PageAccessRepository
                .GetSingleOrDefaultAsync(AccessFilter(sessionBridgeVm.RoleId, true, page));

            bool access = pageAccess != null;

            return access;
        }

        public static Expression<Func<PageAccess, bool>> AccessFilter(int roleId, bool access, string page)
        {
            Expression<Func<PageAccess, bool>> expression = p => p.Access == access && p.RoleId == roleId && p.Page == page;

            return expression;
        }

    }
}
