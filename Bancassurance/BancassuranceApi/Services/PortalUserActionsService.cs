using AutoMapper;
using BancassuranceApi.ViewModels;
using BancassuranceLib.Models;
using BancassuranceLib.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public class PortalUserActionsService : IPortalUserActionsService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkRepo _unitOfWork;

        public PortalUserActionsService(IMapper mapper, IUnitOfWorkRepo unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> AddAsync(SessionBridgeVm sessionBridgeVm, string action, string entityId)
        {
            bool result = false;

            try
            {
                var userAction = _mapper.Map<PortalUserActions>(sessionBridgeVm);

                userAction.Id = 0;
                userAction.Action = action;
                userAction.EntityId = entityId;
                userAction.DateConducted = DateTime.Now;

                await _unitOfWork.PortalUserActionsRepository.AddAsync(userAction);

                await _unitOfWork.SaveChangesAsync();

                result = true;
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception?.Message ?? "Audit error");
            }

            return result;
        }
    }
}
