using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancassuranceApi.ViewModels
{
    public class JsonResult<T>
    {
        public int ErrorCode { get; set; } = -1;
        public T Data { get; set; }
    }
}