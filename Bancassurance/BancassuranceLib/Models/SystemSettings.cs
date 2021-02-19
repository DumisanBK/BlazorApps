using System;
using System.Collections.Generic;

namespace BancassuranceLib.Models
{
    public partial class SystemSettings
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public bool Value { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastDateModified { get; set; }
        public string CreatedBy { get; set; }
    }
}
