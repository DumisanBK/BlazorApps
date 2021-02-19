using BancassuranceLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BancassuranceApi.Expressions
{
    public class SystemSettingsExpression
    {
        public static Expression<Func<SystemSettings, bool>> Filter(int code)
        {
            Expression<Func<SystemSettings, bool>> expression = setting => setting.Code == code;

            return expression;
        }

        public static Func<IQueryable<SystemSettings>, IOrderedQueryable<SystemSettings>> OrderByIdAsc()
        {
            return orderCriteria => orderCriteria.OrderByDescending(s => s.Id);
        }
    }
}
