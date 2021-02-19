using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.ViewModels
{
    public class DependantForm
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(20, ErrorMessage = "Invalid length for {0}", MinimumLength = 3)]
        //[RegularExpression("([a-zA-Z()]+)", ErrorMessage = "Digits are not allowed")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(20, ErrorMessage = "Invalid length for {0}", MinimumLength = 3)]
        //[RegularExpression("([a-zA-Z()]+)", ErrorMessage = "Digits are not allowed")]
        public string SurName { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(15, ErrorMessage = "Invalid length for {0}", MinimumLength = 10)]
        [RegularExpression("([0-9]+)", ErrorMessage = "Only digits are allowed")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(200, ErrorMessage = "Invalid length for {0}", MinimumLength = 1)]
        public string Age { get; set; }

        [Display(Name = "Relationship")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(20, ErrorMessage = "Invalid length for {0}", MinimumLength = 3)]
        //[RegularExpression("([a-zA-Z]+)", ErrorMessage = "Digits are not allowed")]
        public string Relationship { get; set; }
        [Display(Name = "Member Id")]
        [Required(ErrorMessage = "{0} is required")]
        public long MemberId { get; set; }
        [Display(Name = "Input Teller")]
        [Required(ErrorMessage = "{0} is required")]
        public string InputTeller { get; set; }

    }
}
