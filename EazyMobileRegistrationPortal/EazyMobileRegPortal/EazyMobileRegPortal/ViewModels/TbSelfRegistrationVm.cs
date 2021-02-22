using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EazyMobileRegPortal.ViewModels
{
    public class TbSelfRegistrationVm
    {
        public int AcId { get; set; }
        public string AcCustomerNumber { get; set; }
        public string AcAccountNumber { get; set; }
        public string AcAccountName { get; set; }
        public string AcPhoneNumber { get; set; }
        public string AcRegistrationDate { get; set; }
        public string AcStatus { get; set; }
        public string CheckedBy { get; set; }
        public bool Checked { get; set; }
        public DateTime? CheckedDate { get; set; }
        public string ApprovedBy { get; set; }
        public bool Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string DeniedBy { get; set; }
        public bool Denied { get; set; }
        public DateTime? DeniedDate { get; set; }
    }
}
