using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.Resources
{
    public class CustomerData
    {
        public string CustomerName { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public string MobilePhone { get; set; }
        public string SmsPhone { get; set; }
        public string Email { get; set; }
        public string MaritalStatus { get; set; }
        public string DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Occupation { get; set; }
        public string LegalId { get; set; }
        public string CompanyCode { get; set; }
        public long AccCategCode { get; set; }
        public string AccCategDesc { get; set; }
        public string CustomerNumber { get; set; }
        public string AccountTitle { get; set; }
        public string AccountNumber { get; set; }
        public string CustomerCateg { get; set; }
        public string BranchName { get; set; }
        public string PostalAdd { get; set; }
        public string PostalTown { get; set; }
        public string ApplicationDate { get; set; }
        public string LegalDocName { get; set; }
        public string LegalIssDate { get; set; }
        public string LegalExpDate { get; set; }
    }
}
