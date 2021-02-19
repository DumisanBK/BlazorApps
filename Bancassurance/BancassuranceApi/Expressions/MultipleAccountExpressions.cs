using BancassuranceLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BancassuranceApi.Expressions
{
    public class MultipleAccountExpressions
    {
        public static Expression<Func<AccountSettings, bool>> DefaultFilter(string accountNumber)
        {
            Expression<Func<AccountSettings, bool>> expression = account => 
                account.AccountNumber == accountNumber;

            return expression;
        }

        public static Func<IQueryable<AccountSettings>, 
            IOrderedQueryable<AccountSettings>> OrderByIdAsc()
        {
            return orderCriteria => orderCriteria.OrderByDescending(a => a.Id);
        }
    }
}
