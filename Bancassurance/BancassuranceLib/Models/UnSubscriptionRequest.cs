using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceLib.Models
{
    public class UnSubscriptionRequest
    {
        public int id { get; set; }
        public string CustomerName { get; set; }
        public int TurnOverId { get; set; }
        public string AccountNumber { get; set; }
        public string VoidReason { get; set; }
        public virtual TurnOverTypes TurnOver { get; set; }

    }
}
