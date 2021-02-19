using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.ViewModels
{
    public class UserActionsVm
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Branch { get; set; }
        public string Action { get; set; }
        public DateTime DateConducted { get; set; }
        public string EntityId { get; set; }
    }
}
