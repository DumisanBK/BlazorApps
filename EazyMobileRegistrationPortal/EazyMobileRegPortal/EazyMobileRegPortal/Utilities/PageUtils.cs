using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EazyMobileRegPortal.Utilities
{
    public class PageUtils
    {
        public static string GetPage(int index)
        {
            string page = index switch
            {
                1 => "index",
                2 => "uncheckedapprovals",
                3 => "unchecked_approvals_index",
                4 => "checkedapprovals",
                5 => "checked_approvals_index",
                6 => "denied_customers",
                7 => "access_denied",
                _ => "index"
            };

            return page;
        }
    }
}
