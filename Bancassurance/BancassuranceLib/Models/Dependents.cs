using System;
using System.Collections.Generic;

namespace BancassuranceLib.Models
{
    public partial class Dependents
    {
        public long Id { get; set; }
        public long MemberId { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Relationship { get; set; }
        public string InputTeller { get; set; }
        public DateTime DateAdded { get; set; }
        public int Normal { get; set; }
        public int? Void { get; set; }
        public string VoidedBy { get; set; }
        public DateTime? DateVoided { get; set; }

        public virtual MainMemberDetails Member { get; set; }
    }
}
