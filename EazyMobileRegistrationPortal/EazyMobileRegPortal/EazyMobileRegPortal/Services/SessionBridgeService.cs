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
    public class SessionBridgeService
    {
        private readonly IMapper _mapper;               
        private readonly ISessionBridgeRepository _sessionBridgeRepository;

        public SessionBridgeService(IMapper mapper, ISessionBridgeRepository sessionBridgeRepository)
        {
            _mapper = mapper;
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
