using AutoMapper;
using EazyMobileRegPortal.Models;
using EazyMobileRegPortal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EazyMobileRegPortal.Mapper
{
    public class PortalUserActionMapper
    {
        private readonly IMapper _mapper;

        public PortalUserActionMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public PortalUserActions Map(string entityId, string action, SessionBridgeVm sessionBridge)
        {
            var userAction = _mapper.Map<PortalUserActions>(sessionBridge);
            
            userAction.Id = 0;
            userAction.Action = action;
            userAction.EntityId = entityId;
            userAction.DateConducted = DateTime.Now;

            return userAction;
        }
    }
}
