using System;
using System.Collections.Generic;

namespace BancassuranceLib.Models
{
    public partial class DeletedEntities
    {
        public int Id { get; set; }
        public string EntityAsJson { get; set; }
        public string Inputter { get; set; }
        public int EntityType { get; set; }
        public DateTime DateConducted { get; set; }
    }
}
