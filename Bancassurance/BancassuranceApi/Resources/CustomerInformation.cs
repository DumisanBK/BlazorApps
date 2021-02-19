using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancassuranceApi.Resources
{
    public class CustomerInformation
    {
        public string LegacyCustomerNumber { get; set; }
        public string CustomerNumber { get; set; }
        public string CellPhone { get; set; }
        public string CustomerName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public string MaritalStatus { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string MobilePhone { get; set; }
    }
}