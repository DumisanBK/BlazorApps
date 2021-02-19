using System;
using System.Collections.Generic;

namespace BancassuranceLib.Models
{
    public partial class UnsubscribeRequests
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string Reason { get; set; }
    }
}
