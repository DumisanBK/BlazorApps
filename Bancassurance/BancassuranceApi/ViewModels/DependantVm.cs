using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.ViewModels
{
    public class DependantVm
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Relationship { get; set; }
        public long MemberId { get; set; }
        public string InputTeller { get; set; }
        public DateTime DateAdded { get; set; }
        public int Normal { get; set; }
        public int? Void { get; set; }
        public string VoidedBy { get; set; }
        public DateTime? DateVoided { get; set; }

        public virtual MemberVm Member { get; set; }
    }
}
