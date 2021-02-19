using System;
using System.Collections.Generic;

namespace BancassuranceLib.Models
{
    public partial class Branches
    {
        public string BranchId { get; set; }
        public string BranchName { get; set; }
        public string Mnemonic { get; set; }
        public string PrimaryAccountOfficer { get; set; }
        public string OtherAccountOfficer { get; set; }
        public string Location { get; set; }
    }
}
