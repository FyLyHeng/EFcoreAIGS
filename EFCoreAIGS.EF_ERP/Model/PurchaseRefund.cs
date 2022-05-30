using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class PurchaseRefund
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? CustomStatus { get; set; }
        public DateTime? Date { get; set; }
        public double? DebitNoteAmount { get; set; }
        public string? PaymentOption { get; set; }
        public string? ReferenceNo { get; set; }
        public double? RefundAmount { get; set; }
        public string? Remark { get; set; }
        public string? Series { get; set; }
        public long? DebitNoteId { get; set; }
        public long? GlAccountId { get; set; }
        public long? SupplierId { get; set; }

        public virtual DebitNote? DebitNote { get; set; }
        public virtual ChartOfAccount? GlAccount { get; set; }
        public virtual Supplier? Supplier { get; set; }
    }
}
