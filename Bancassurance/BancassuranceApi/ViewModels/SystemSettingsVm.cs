using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.ViewModels
{
    public class SystemSettingsVm
    {
        public int Id { get; set; }
        public int Code { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Value")]
        [Required(ErrorMessage = "{0} is required")]
        public bool Value { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastDateModified { get; set; }
        public string CreatedBy { get; set; }
    }
}
