using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.ViewModels
{
    public class RejectUnsubscriptionRequest
    {
        [Display(Name = "Member Id")]
        [Required(ErrorMessage = "{0} is required")]
        public long MemberId { get; set; }
        [Display(Name = "Requester")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "Invalid length for {0}", MinimumLength = 1)]
        public string Voider { get; set; }
    }
}
