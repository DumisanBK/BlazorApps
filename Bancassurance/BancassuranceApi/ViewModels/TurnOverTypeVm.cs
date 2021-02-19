using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.ViewModels
{
    public class TurnOverTypeVm
    {
        public TurnOverTypeVm()
        {
            Members = new HashSet<MemberVm>();
        }

        public int TurnOverId { get; set; }
        public string TurnOverType { get; set; }
        public decimal Amount { get; set; }
        public decimal? AdditionaPremium { get; set; }

        public virtual ICollection<MemberVm> Members { get; set; }
    }
}
