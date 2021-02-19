using System;
using System.Collections.Generic;

namespace BancassuranceLib.Models
{
    public partial class AccountSettings
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public bool MultipleMembers { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool Deleted { get; set; }
    }
}
