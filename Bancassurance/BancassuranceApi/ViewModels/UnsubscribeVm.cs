using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.ViewModels
{
    public class UnsubscribeVm
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Customer Name")]
        public string FullName { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Account No")]
        public string AccountNumber { get; set; }

        [Display(Name = "Reason")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(500, ErrorMessage = "Invalid length for {0}", MinimumLength = 3)]
        public string Reason { get; set; }

    }
}
