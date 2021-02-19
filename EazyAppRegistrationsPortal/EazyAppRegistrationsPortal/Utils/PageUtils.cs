using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EazyAppRegistrationsPortal.Utils
{
    public class PageUtils
    {
        public static string GetPage(int index)
        {
            string page = index switch
            {
                1 => "index",
                2 => "uncheckedapprovals",
                3 => "unchecked",
                4 => "checkedapprovals",
                5 => "checked",
                6 => "access_denied",
                _ => "index"
            };

            return page;
        }
    }
}
