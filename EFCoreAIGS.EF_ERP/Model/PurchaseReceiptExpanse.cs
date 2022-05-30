using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class PurchaseReceiptExpanse
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public double? Amount { get; set; }
        public string? Remark { get; set; }
        public long? ExpanseCategoryId { get; set; }
        public long? PurchaseReceiptId { get; set; }
        public long? SupplierId { get; set; }

        public virtual ExpanseCategory? ExpanseCategory { get; set; }
        public virtual PurchaseReceipt? PurchaseReceipt { get; set; }
        public virtual Supplier? Supplier { get; set; }
    }
}
