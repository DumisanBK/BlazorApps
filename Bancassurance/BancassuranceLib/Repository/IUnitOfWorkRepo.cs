using BancassuranceLib.Models;
using System.Threading.Tasks;

namespace BancassuranceLib.Repository
{
    public interface IUnitOfWorkRepo
    {
        IGenericRepository<AccountSettings> AccountSettingsRepository { get; }
        IGenericRepository<Dependents> DependantsRepository { get; }
        IGenericRepository<MainMemberDetails> MemberRepository { get; }
        IGenericRepository<PageAccess> PageAccessRepository { get; }
        IGenericRepository<PortalUserActions> PortalUserActionsRepository { get; }
        IGenericRepository<PortalUserSessionBridge> PortalUserSessionBridgeRepository { get; }
        IGenericRepository<Relationships> RelationshipsRepository { get; }
        IGenericRepository<Titles> TitlesRepository { get; }
        IGenericRepository<TurnOverTypes> TurnOverTypesRepository { get; }
        IGenericRepository<SystemSettings> SystemSettingsRepository { get; }
        IGenericRepository<DeletedEntities> DeletedEntitiesRepository { get; }
        Task SaveChangesAsync();
    }
}