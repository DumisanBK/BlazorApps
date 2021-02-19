using AutoMapper;
using BancassuranceApi.ViewModels;
using BancassuranceLib.Models;

namespace BancaPortal.Mappers
{
    public class BancaMapper : Profile
    {
        public BancaMapper()
        {
            CreateMap<MainMemberDetails, UnSubscriptionRequest>().ReverseMap();
            CreateMap<UnSubscriptionRequest, UnSubscriptionRequestVm>().ReverseMap();
            CreateMap<MainMemberDetails, MemberVm>().ReverseMap();
            CreateMap<Dependents, DependantVm>().ReverseMap();
            CreateMap<TurnOverTypes, TurnOverTypeVm>().ReverseMap();
            CreateMap<SpecialAccountVm, AccountSettings>().ReverseMap();
            CreateMap<MemberVm, UnsubscribeForm>().ReverseMap();
            CreateMap<DependantVm, DependantForm>().ReverseMap();
            CreateMap<PolicyForm, MainMemberDetails>().ReverseMap();
            CreateMap<DefaultPlatformVm, Platform>().ReverseMap();
            CreateMap<PortalUserSessionBridge, SessionBridgeVm>().ReverseMap();
            CreateMap<PortalUserActions, UserActionsVm>().ReverseMap();
            CreateMap<PageAccess, PageAccessVm>().ReverseMap();
            CreateMap<Titles, TitlesVm>().ReverseMap();
            CreateMap<Relationships, RelationshipsVm>().ReverseMap();
            CreateMap<SessionBridgeVm, PortalUserActions>();
            CreateMap<SystemSettingsVm, SystemSettings>().ReverseMap();
        }
    }
}
