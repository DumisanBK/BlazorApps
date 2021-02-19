using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancassuranceApi.Resources
{
    public class AccountInfo
    {
        public string CustomerNumber { get; set; }
        public string AccountNumber { get; set; }
        public string AccountTitle { get; set; }
        public string CompanyCode { get; set; }
        public int CategoryCode { get; set; }
        public string CategoryDescription { get; set; }
    }
}