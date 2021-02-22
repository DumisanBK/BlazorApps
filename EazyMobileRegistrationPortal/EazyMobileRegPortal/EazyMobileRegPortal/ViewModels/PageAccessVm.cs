using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EazyMobileRegPortal.ViewModels
{
    public class PageAccessVm
    {
        public int Id { get; set; }
        public string Page { get; set; }
        public int RoleId { get; set; }
        public bool Access { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
