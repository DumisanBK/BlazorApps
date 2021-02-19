using BancassuranceLib.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BancassuranceLib.Repository
{
    public class UnitOfWorkRepo : IUnitOfWorkRepo
    {
        private readonly BancassuranceContext _bancassuranceContext;

        private IGenericRepository<AccountSettings> accountSettingsRepository;
        private IGenericRepository<MainMemberDetails> memberRepository;
        private IGenericRepository<Dependents> dependantsRepository;
        private IGenericRepository<Titles> titlesRepository;
        private IGenericRepository<Relationships> relationshipsRepository;
        private IGenericRepository<TurnOverTypes> turnOverTypesRepository;
        private IGenericRepository<PortalUserActions> portalUserActionsRepository;
        private IGenericRepository<PortalUserSessionBridge> portalUserSessionBridgeRepository;
        private IGenericRepository<PageAccess> pageAccessRepository;
        private IGenericRepository<SystemSettings> systemSettingsRepository;
        private IGenericRepository<DeletedEntities> deletedEntitiesRepository;

        public UnitOfWorkRepo(BancassuranceContext bancassuranceContext)
        {
            _bancassuranceContext = bancassuranceContext;
        }

        public IGenericRepository<Dependents> DependantsRepository
        {
            get
            {
                if (dependantsRepository == null)
                    dependantsRepository = new GenericRepository<Dependents>(_bancassuranceContext);

                return dependantsRepository;
            }
        }

        public IGenericRepository<MainMemberDetails> MemberRepository
        {
            get
            {
                if (memberRepository == null)
                    memberRepository = new GenericRepository<MainMemberDetails>(_bancassuranceContext);

                return memberRepository;
            }
        }

        public IGenericRepository<Titles> TitlesRepository
        {
            get
            {
                if (titlesRepository == null)
                    titlesRepository = new GenericRepository<Titles>(_bancassuranceContext);

                return titlesRepository;
            }
        }

        public IGenericRepository<Relationships> RelationshipsRepository
        {
            get
            {
                if (relationshipsRepository == null)
                    relationshipsRepository = new GenericRepository<Relationships>(_bancassuranceContext);

                return relationshipsRepository;
            }
        }

        public IGenericRepository<TurnOverTypes> TurnOverTypesRepository
        {
            get
            {
                if (turnOverTypesRepository == null)
                    turnOverTypesRepository = new GenericRepository<TurnOverTypes>(_bancassuranceContext);

                return turnOverTypesRepository;
            }
        }

        public IGenericRepository<PortalUserActions> PortalUserActionsRepository
        {
            get
            {
                if (portalUserActionsRepository == null)
                    portalUserActionsRepository = new GenericRepository<PortalUserActions>(_bancassuranceContext);

                return portalUserActionsRepository;
            }
        }

        public IGenericRepository<PortalUserSessionBridge> PortalUserSessionBridgeRepository
        {
            get
            {
                if (portalUserSessionBridgeRepository == null)
                    portalUserSessionBridgeRepository = new GenericRepository<PortalUserSessionBridge>(_bancassuranceContext);

                return portalUserSessionBridgeRepository;
            }
        }

        public IGenericRepository<PageAccess> PageAccessRepository
        {
            get
            {
                if (pageAccessRepository == null)
                    pageAccessRepository = new GenericRepository<PageAccess>(_bancassuranceContext);

                return pageAccessRepository;
            }
        }

        public IGenericRepository<AccountSettings> AccountSettingsRepository
        {
            get
            {
                if (accountSettingsRepository == null)
                    accountSettingsRepository = new GenericRepository<AccountSettings>(_bancassuranceContext);

                return accountSettingsRepository;
            }
        }

        public IGenericRepository<SystemSettings> SystemSettingsRepository
        {
            get
            {
                if (systemSettingsRepository == null)
                    systemSettingsRepository = new GenericRepository<SystemSettings>(_bancassuranceContext);

                return systemSettingsRepository;
            }
        }

        public IGenericRepository<DeletedEntities> DeletedEntitiesRepository
        {
            get
            {
                if (deletedEntitiesRepository == null)
                    deletedEntitiesRepository = new GenericRepository<DeletedEntities>(_bancassuranceContext);

                return deletedEntitiesRepository;
            }
        }

        public async Task SaveChangesAsync()
        {
            await _bancassuranceContext.SaveChangesAsync();
        }
    }
}
