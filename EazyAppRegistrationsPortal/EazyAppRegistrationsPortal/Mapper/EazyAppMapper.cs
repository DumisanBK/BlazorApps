using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EazyAppRegistrationsPortal.Models;
using EazyAppRegistrationsPortal.ViewModels;

namespace EazyAppRegistrationsPortal.Mapper
{
    public class EazyAppMapper : Profile
    {
        public EazyAppMapper()
        {
            CreateMap<Customers, CustomerVm>();
            CreateMap<PortalUserActions, UserActionsVm>();
            CreateMap<PortalUserSessionBridge, SessionBridgeVm>();
            CreateMap<SessionBridgeVm, PortalUserActions>();
        }
    }
}
