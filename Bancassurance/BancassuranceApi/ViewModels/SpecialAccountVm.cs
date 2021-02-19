using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.ViewModels
{
    public class SpecialAccountVm
    {
        public int Id { get; set; }
        [Display(Name = "Account No")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(20, ErrorMessage = "Invalid length for {0}", MinimumLength = 6)]
        [RegularExpression("([0-9]+)", ErrorMessage = "Only digits are allowed")]
        public string AccountNumber { get; set; }
        [Display(Name = "Account Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(100, ErrorMessage = "Invalid length for {0}", MinimumLength = 3)]
        public string AccountName { get; set; }
        public bool MultipleMembers { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool Deleted { get; set; }
    }
}
