using BancassuranceLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BancassuranceApi.Expressions
{
    public class DependantsExpressions
    {
        public static Expression<Func<Dependents, bool>> TypeFilter(long memberId, long dependanType)
        {
            Expression<Func<Dependents, bool>> expression = dependant => dependant.Normal == dependanType
                && dependant.MemberId == memberId;

            return expression;
        }

        public static Func<IQueryable<Dependents>, IOrderedQueryable<Dependents>> OrderByIdAsc()
        {
            return orderCriteria => orderCriteria.OrderByDescending(d => d.Id);
        }
    }
}
