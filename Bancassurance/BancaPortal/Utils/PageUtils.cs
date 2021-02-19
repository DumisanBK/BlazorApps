using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancaPortal.Utils
{
    public class PageUtils
    {
        public static string GetPage(int index)
        {
            string page = index switch
            {
                1 => "index",
                2 => "white_listed_accounts",
                3 => "dependants",
                4 => "members",
                5 => "policies",
                6 => "unsubscriptions",
                7 => "add_member",
                8 => "accounts",
                _ => "home"
            };

            return page;
        }
        
    }
}
