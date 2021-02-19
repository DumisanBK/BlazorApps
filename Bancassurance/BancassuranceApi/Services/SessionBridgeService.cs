using AutoMapper;
using BancassuranceApi.Expressions;
using BancassuranceApi.ViewModels;
using BancassuranceLib.Models;
using BancassuranceLib.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public class SessionBridgeService : ISessionBridgeService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkRepo _unitOfWork;

        public SessionBridgeService(IMapper mapper, IUnitOfWorkRepo unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<SessionBridgeVm> GetSessionBridgeAsync(string guid, bool forfeitKey = false)
        {
            var sessionBridge = await _unitOfWork.PortalUserSessionBridgeRepository
                 .GetSingleOrDefaultAsync(SessionBridgeExpressions.GuidFilter(guid));

            if (sessionBridge == null) return null;

            if (forfeitKey)
            {
                sessionBridge.Used = true;
                await UpdateSessionBridgeAsync(sessionBridge);
            }

            return _mapper.Map<SessionBridgeVm>(sessionBridge);
        }

        public async Task<List<SessionBridgeVm>> GetSessionBridgesAsync(
            Expression<Func<PortalUserSessionBridge, bool>> filter = null,
            Func<IQueryable<PortalUserSessionBridge>, IOrderedQueryable<PortalUserSessionBridge>> orderBy = null)
        {
            if (orderBy == null)
                orderBy = SessionBridgeExpressions.OrderByIdAsc();

            var bridges = (await _unitOfWork.PortalUserSessionBridgeRepository
                .GetAllAsync(filter, orderBy))
                .Select(b => _mapper.Map<SessionBridgeVm>(b))
                .ToList();

            if (bridges.Count < 1) return null;

            return bridges;
        }

        public async Task<bool> UpdateSessionBridgeAsync(SessionBridgeVm sessionBridgeVm)
        {
            var sessionBridge = _mapper.Map<PortalUserSessionBridge>(sessionBridgeVm);

            return await UpdateSessionBridgeAsync(sessionBridge);
        }

        public async Task<bool> UpdateSessionBridgeAsync(PortalUserSessionBridge sessionBridge)
        {
            await _unitOfWork.PortalUserSessionBridgeRepository.UpdateAsync(sessionBridge);

            await _unitOfWork.SaveChangesAsync();

            return true;
        }
    }
}
