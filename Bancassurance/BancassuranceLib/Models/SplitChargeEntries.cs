using System;
using System.Collections.Generic;

namespace BancassuranceLib.Models
{
    public partial class SplitChargeEntries
    {
        public int Line { get; set; }
        public string ServiceType { get; set; }
        public string ServiceId { get; set; }
        public string AccountNumber { get; set; }
        public int? Category { get; set; }
        public string CategoryDescription { get; set; }
        public string CustomerName { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string ChargeAccount { get; set; }
        public decimal? ChargeAmount { get; set; }
        public string RefTransactionId { get; set; }
        public string ChargeDescription { get; set; }
        public DateTime ChargeDate { get; set; }
        public DateTime? PostDate { get; set; }
        public string TransactionId { get; set; }
        public string Narration { get; set; }
        public string Ofsrequest { get; set; }
        public string Ofsresponse { get; set; }
        public int Posted { get; set; }
    }
}
