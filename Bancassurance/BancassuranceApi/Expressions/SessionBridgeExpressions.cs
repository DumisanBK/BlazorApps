using BancassuranceApi.Utils;
using BancassuranceLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BancassuranceApi.Expressions
{
    public class SessionBridgeExpressions
    {
        public static Expression<Func<PortalUserSessionBridge, bool>> GuidFilter(string guid)
        {
            DateTime now = DateTime.Now;

            Expression<Func<PortalUserSessionBridge, bool>> expression = bridge => bridge.SessionId == guid
                && bridge.Used == false
                && bridge.DateGenerated.Year == now.Year
                && bridge.DateGenerated.Month == now.Month
                && bridge.DateGenerated.Day == now.Day;

            return expression;
        }

        public static Func<IQueryable<PortalUserSessionBridge>, 
            IOrderedQueryable<PortalUserSessionBridge>> OrderByIdAsc()
        {
            return orderCriteria => orderCriteria.OrderByDescending(d => d.Id);
        }
    }
}
