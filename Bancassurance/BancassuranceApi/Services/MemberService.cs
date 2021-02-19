using AutoMapper;
using BancassuranceApi.Expressions;
using BancassuranceApi.Utils;
using BancassuranceApi.ViewModels;
using BancassuranceLib.Models;
using BancassuranceLib.Repository;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkRepo _unitOfWorkRepo;
        private readonly IStringExtensions _stringExtensions;
        private readonly BancassuranceContext _bancassuranceContext;

        public MemberService(IMapper mapper, IUnitOfWorkRepo unitOfWorkRepo,
            IStringExtensions stringExtensions,
            BancassuranceContext bancassuranceContext)
        {
            _mapper = mapper;
            _unitOfWorkRepo = unitOfWorkRepo;
            _stringExtensions = stringExtensions;
            _bancassuranceContext = bancassuranceContext;
        }

        public async Task<bool> AnyAsync(Expression<Func<MainMemberDetails, bool>> filter)
        {
            bool any = await _bancassuranceContext.MainMemberDetails.AnyAsync(filter);

            return any;
        }

        public async Task<bool> AddMemberAsync(PolicyForm policyForm)
        {
            var member = _mapper.Map<MainMemberDetails>(policyForm);

            await _unitOfWorkRepo.MemberRepository.AddAsync(member);

            await _unitOfWorkRepo.SaveChangesAsync();

            return true;
        }

        public async Task<List<MemberVm>> GetMembersAsync(Expression<Func<MainMemberDetails, bool>> filter = null,
            Func<IQueryable<MainMemberDetails>, IOrderedQueryable<MainMemberDetails>> orderBy = null)
        {
            if (orderBy == null)
                orderBy = MemberExpressions.OrderByIdAsc();

            var members = (await _unitOfWorkRepo.MemberRepository.GetAllAsync(filter, orderBy, "Dependents,TurnOver"))
                .Select(member => _mapper.Map<MemberVm>(member))
                .ToList();

            if (members.Count < 1) return null;

            return members;
        }

        public async Task<MemberVm> GetMemberAsync(long id)
        {
            var member = await _unitOfWorkRepo.MemberRepository.GetByIdAsync(id);

            if (member == null) return null;

            return _mapper.Map<MemberVm>(member);
        }

        public async Task<MemberVm> GetMemberAsync(Expression<Func<MainMemberDetails, bool>> filter)
        {
            var member = await _unitOfWorkRepo.MemberRepository.GetSingleOrDefaultAsync(filter);

            if (member == null) return null;

            return _mapper.Map<MemberVm>(member);
        }

        public async Task<bool> RemoveMembersByAccount(string account, string inputter)
        {
            var members = await _bancassuranceContext.MainMemberDetails
                 .Where(m => m.AccountNumber == account)
                 .ToListAsync();

            if (members.Count < 1) return false;
            
            foreach(var member in members)
            {
                _bancassuranceContext.Remove(member);
                
                await _bancassuranceContext.AddAsync(new DeletedEntities
                {
                    EntityAsJson = _stringExtensions.Trim(JsonConvert.SerializeObject(_mapper.Map<MemberVm>(member)), 1000),
                    Inputter = inputter,
                    EntityType = 1
                });
            }

            await _bancassuranceContext.SaveChangesAsync();

            return true;
        }

    }
}
