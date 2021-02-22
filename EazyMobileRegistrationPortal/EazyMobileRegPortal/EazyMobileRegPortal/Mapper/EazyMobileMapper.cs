using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EazyMobileRegPortal.Models;
using EazyMobileRegPortal.ViewModels;

namespace EazyMobileRegPortal.Mapper
{
    public class EazyMobileMapper : Profile
    {

        public EazyMobileMapper()
        {
            CreateMap<TbSelfRegistration, TbSelfRegistrationVm>().ReverseMap();
            CreateMap<PortalUserSessionBridge, SessionBridgeVm>().ReverseMap();
            CreateMap<PortalUserActions, UserActionsVm>().ReverseMap();
            CreateMap<SessionBridgeVm, PortalUserActions>();
        }
    }
}
