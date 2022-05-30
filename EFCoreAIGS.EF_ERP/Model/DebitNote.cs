using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class DebitNote
    {
        public DebitNote()
        {
            PurchaseRefunds = new HashSet<PurchaseRefund>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? CustomStatus { get; set; }
        public DateTime? Date { get; set; }
        public double? DiscountAmount { get; set; }
        public double? DiscountPercentage { get; set; }
        public double? GrandTotal { get; set; }
        public bool? IsIncludeVat { get; set; }
        public string? Remark { get; set; }
        public string? Series { get; set; }
        public double? SubTotal { get; set; }
        public double? VatAmount { get; set; }
        public double? VatPercentage { get; set; }
        public long? PurchaseReturnId { get; set; }
        public long? SupplierId { get; set; }

        public virtual PurchaseReturn? PurchaseReturn { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual ICollection<PurchaseRefund> PurchaseRefunds { get; set; }
    }
}
