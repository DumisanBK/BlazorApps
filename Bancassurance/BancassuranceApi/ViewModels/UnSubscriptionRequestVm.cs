using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.ViewModels
{
    public class UnSubscriptionRequestVm
    {
        public int id { get; set; }
        public string CustomerName { get; set; }
        public string AccountNumber { get; set; }
        public string VoidReason { get; set; }
        public virtual TurnOverTypeVm TurnOver { get; set; }
    }
}
