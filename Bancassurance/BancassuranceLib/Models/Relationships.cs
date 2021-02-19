using System;
using System.Collections.Generic;

namespace BancassuranceLib.Models
{
    public partial class Relationships
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
