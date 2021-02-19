using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EazyAppRegistrationsPortal.ViewModels
{
    public class CustomerVm
    {
        public string CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int WrongLoginAttempts { get; set; }
        public DateTime PinExpiry { get; set; }
        public DateTime? LastLogin { get; set; }
        public int LoginCounts { get; set; }
        public short ChangePin { get; set; }
        public DateTime DateAdded { get; set; }
        public string RegisteredChannel { get; set; }
        public string BranchCode { get; set; }
        public bool Checked { get; set; }
        public bool Approved { get; set; }
        public bool Denied { get; set; }
        public string CheckedBy { get; set; }
        public string ApprovedBy { get; set; }
        public string DeniedBy { get; set; }
        public DateTime? DateChecked { get; set; }
        public DateTime? DateApproved { get; set; }
        public DateTime? DateDenied { get; set; }
    }
}
