using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.Resources
{
    public class T24Message<T>
    {
        public int MessageCode { get; set; }
        public T MessageData { get; set; }
        public string MessageAlert { get; set; }
    }
}
