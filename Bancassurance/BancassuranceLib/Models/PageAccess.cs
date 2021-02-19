using System;
using System.Collections.Generic;

namespace BancassuranceLib.Models
{
    public partial class PageAccess
    {
        public int Id { get; set; }
        public string Page { get; set; }
        public int RoleId { get; set; }
        public bool Access { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
