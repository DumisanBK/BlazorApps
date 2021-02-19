using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BancassuranceApi.ViewModels;

namespace BancassuranceApi.Resources
{
    public class CustomerQuery
    {
        public string Number { get; set; }
        public Platform Platform { get; set; }
    }
}