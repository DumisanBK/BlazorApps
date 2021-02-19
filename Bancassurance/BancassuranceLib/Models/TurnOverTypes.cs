using System;
using System.Collections.Generic;

namespace BancassuranceLib.Models
{
    public partial class TurnOverTypes
    {
        public TurnOverTypes()
        {
            MainMemberDetails = new HashSet<MainMemberDetails>();
        }

        public int TurnOverId { get; set; }
        public string TurnOverType { get; set; }
        public decimal Amount { get; set; }
        public decimal? AdditionaPremium { get; set; }

        public virtual ICollection<MainMemberDetails> MainMemberDetails { get; set; }
    }
}
