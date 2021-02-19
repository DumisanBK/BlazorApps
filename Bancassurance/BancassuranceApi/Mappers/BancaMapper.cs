using AutoMapper;
using BancassuranceApi.ViewModels;
using BancassuranceApi.ViewModels;
using BancassuranceLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.Mappers
{
    public class BancaMapper : Profile
    {
        public BancaMapper()
        {
            CreateMap<MainMemberDetails, UnSubscriptionRequest>().ReverseMap();
            CreateMap<UnSubscriptionRequest, UnSubscriptionRequestVm>().ReverseMap();
            CreateMap<MainMemberDetails, MemberVm>().ReverseMap();
            CreateMap<Dependents, DependantVm>().ReverseMap();
            CreateMap<DependantForm, Dependents>().ReverseMap();
            CreateMap<TurnOverTypes, TurnOverTypeVm>().ReverseMap();
            CreateMap<SpecialAccountVm, AccountSettings>().ReverseMap();
            CreateMap<MemberVm, UnsubscribeForm>().ReverseMap();
            CreateMap<DependantVm, DependantForm>().ReverseMap();
            CreateMap<PolicyForm, MainMemberDetails>().ReverseMap();
            CreateMap<PortalUserSessionBridge, SessionBridgeVm>().ReverseMap();
            CreateMap<PortalUserActions, UserActionsVm>().ReverseMap();
            CreateMap<PageAccess, PageAccessVm>().ReverseMap();
            CreateMap<Titles, TitlesVm>().ReverseMap();
            CreateMap<Relationships, RelationshipsVm>().ReverseMap();
            CreateMap<SessionBridgeVm, PortalUserActions>().ReverseMap();
            CreateMap<DefaultPlatformVm, Platform>().ReverseMap();
            CreateMap<SystemSettingsVm, SystemSettings>().ReverseMap();
        }
    }
}
