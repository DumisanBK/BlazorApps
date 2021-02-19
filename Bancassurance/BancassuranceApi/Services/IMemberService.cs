using BancassuranceApi.ViewModels;
using BancassuranceLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BancassuranceApi.Services
{
    public interface IMemberService
    {
        Task<bool> AddMemberAsync(PolicyForm policyForm);
        Task<bool> AnyAsync(Expression<Func<MainMemberDetails, bool>> filter);
        Task<MemberVm> GetMemberAsync(Expression<Func<MainMemberDetails, bool>> filter);
        Task<MemberVm> GetMemberAsync(long id);
        Task<List<MemberVm>> GetMembersAsync(Expression<Func<MainMemberDetails, bool>> filter = null, Func<IQueryable<MainMemberDetails>, IOrderedQueryable<MainMemberDetails>> orderBy = null);
        Task<bool> RemoveMembersByAccount(string account, string inputter);
    }
}