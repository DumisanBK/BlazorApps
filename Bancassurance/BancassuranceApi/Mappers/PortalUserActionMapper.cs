using AutoMapper;
using BancassuranceLib.Models;
using BancassuranceApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.Mappers
{
    public class PortalUserActionMapper : IPortalUserActionMapper
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
            userAction.EntityId = entityId;
            userAction.Action = action;
            userAction.DateConducted = DateTime.Now;

            return userAction;
        }

        public PortalUserActions Map(string entityId, string action, string username)
        {
            var userAction = new PortalUserActions
            {
                Id = 0,
                EntityId = entityId,
                Action = action,
                Branch = string.Empty,
                DateConducted = DateTime.Now,
                FullName = username,
                Username = username
            };

            return userAction;
        }
    }
}
