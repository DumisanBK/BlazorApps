using BlazorInputFile;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.ViewModels
{
    public class PolicyForm
    {
        [Display(Name = "Account Number")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(16, ErrorMessage = "Invalid length for {0}", MinimumLength = 6)]
        [RegularExpression("([0-9]+)", ErrorMessage = "Only digits are allowed")]
        public string AccountNumber { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(8, ErrorMessage = "Invalid length for {0}", MinimumLength = 2)]
        public string Title { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(20, ErrorMessage = "Invalid length for {0}", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(20, ErrorMessage = "Invalid length for {0}", MinimumLength = 3)]
        public string SurName { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(16, ErrorMessage = "Invalid length for {0}", MinimumLength = 9)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "{0} is required")]
        public string Gender { get; set; }

        [Display(Name = "Policy Type")]
        [Required(ErrorMessage = "{0} is required")]
        public string PolicyType { get; set; }

        [Display(Name = "Customer Picture")]
        public IFileListEntry Picture { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "{0} is required")]
        public string Age { get; set; }
        public int TurnOverId { get; set; }
        public string PictureAsString { get; set; }
        public string Cashier { get; set; }
        public string CustomerName { get; set; }
        public string Category { get; set; }
        public string CategoryDescription { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public DateTime? DateCreated { get; set; }

    }
}
