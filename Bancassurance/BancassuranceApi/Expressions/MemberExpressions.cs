using BancassuranceLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BancassuranceApi.Expressions
{
    public class MemberExpressions
    {
        public static Expression<Func<MainMemberDetails, bool>> FilterByAccount(string account)
        {
            Expression<Func<MainMemberDetails, bool>> expression = member => member.AccountNumber == account;

            return expression;
        }

        public static Expression<Func<MainMemberDetails, bool>> FilterByVoidAuthorization(string code)
        {
            Expression<Func<MainMemberDetails, bool>> expression = member => member.VoidAuthorization == code;

            return expression;
        }

        public static Expression<Func<MainMemberDetails, bool>> DefaultFilter(string code)
        {
            Expression<Func<MainMemberDetails, bool>> expression = member => 
                string.IsNullOrEmpty(member.VoidAuthorization) ||
                member.VoidAuthorization == code;

            return expression;
        }

        public static Func<IQueryable<MainMemberDetails>, IOrderedQueryable<MainMemberDetails>> OrderByIdAsc()
        {
            return orderCriteria => orderCriteria.OrderByDescending(m => m.Id);
        }
    }
}
