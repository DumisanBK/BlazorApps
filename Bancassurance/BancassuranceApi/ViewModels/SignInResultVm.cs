using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.ViewModels
{
    public class SignInResultVm
    {
        public string Token { get; set; }
        public SessionBridgeVm SessionBridge { get; set; }
    }
}
