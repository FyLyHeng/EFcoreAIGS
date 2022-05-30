using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class CustomerPaymentEntryReference
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public double? Invamount { get; set; }
        public int? Invid { get; set; }
        public double? Invoutstanding { get; set; }
        public string? Invseries { get; set; }
        public int? Soid { get; set; }
        public string? Soseries { get; set; }
        public double? AmountToReceive { get; set; }
        public double? ApplyPrepayment { get; set; }
        public double? Balance { get; set; }
        public string? CustomStatus { get; set; }
        public long? CustomerPaymentEntryId { get; set; }

        public virtual CustomerPaymentEntry? CustomerPaymentEntry { get; set; }
    }
}
