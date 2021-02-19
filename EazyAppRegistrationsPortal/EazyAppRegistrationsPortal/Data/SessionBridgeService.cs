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
    public class SessionBridgeService
    {
        private readonly IMapper _mapper;        
        private readonly SmartAppContext _smartAppContext;        
        private readonly ISessionBridgeRepository _sessionBridgeRepository;

        public SessionBridgeService(IMapper mapper,
            SmartAppContext smartAppContext, ISessionBridgeRepository sessionBridgeRepository)
        {
            _mapper = mapper;           
            _smartAppContext = smartAppContext;
            _sessionBridgeRepository = sessionBridgeRepository;
        }

        public async Task<SessionBridgeVm> ValidateId(string id)
        {
            var sessionBridge = await _sessionBridgeRepository
                .GetSessionBridgeAsync(id);
                        
            if (sessionBridge == null)
            {
                return null;
            }

            var sessionBridgeVm = _mapper.Map<SessionBridgeVm>(sessionBridge);

            return sessionBridgeVm;
        }      

    }
}
