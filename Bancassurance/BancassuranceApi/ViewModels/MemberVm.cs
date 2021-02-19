using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.ViewModels
{
    public class MemberVm
    {
        public MemberVm()
        {
            Dependents = new HashSet<DependantVm>();
        }

        public long Id { get; set; }
        public int TurnOverId { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string AccountNumber { get; set; }
        public string Category { get; set; }
        public string CategoryDescription { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Cashier { get; set; }
        public string VoidAuthorization { get; set; }
        public string VoidRequestedBy { get; set; }
        public DateTime? DateVoidRequested { get; set; }
        public int? Void { get; set; }
        public string VoidedBy { get; set; }
        public DateTime? DateVoided { get; set; }
        public string VoidReason { get; set; }
        public string ReportedToMasm { get; set; }

        public virtual TurnOverTypeVm TurnOver { get; set; }
        public virtual ICollection<DependantVm> Dependents { get; set; }
    }
}
