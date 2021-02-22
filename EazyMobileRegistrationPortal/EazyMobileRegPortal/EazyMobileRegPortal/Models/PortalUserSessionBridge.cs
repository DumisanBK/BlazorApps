using System;
using System.Collections.Generic;

namespace EazyMobileRegPortal.Models
{
    public partial class PortalUserSessionBridge
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Branch { get; set; }
        public bool Used { get; set; }
        public DateTime DateGenerated { get; set; }
        public string SessionId { get; set; }
        public int RoleId { get; set; }
        public int TellerId { get; set; }
    }
}
