using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class PurchaseReturn
    {
        public PurchaseReturn()
        {
            DebitNotes = new HashSet<DebitNote>();
            PurchaseReturnDetails = new HashSet<PurchaseReturnDetail>();
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
        public double? DiscountPercent { get; set; }
        public string? Remark { get; set; }
        public string? Series { get; set; }
        public double? SubTotal { get; set; }
        public double? Total { get; set; }
        public double? VatAmount { get; set; }
        public double? VatPercent { get; set; }
        public long? SupplierId { get; set; }
        public long? WarehouseId { get; set; }

        public virtual Supplier? Supplier { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
        public virtual ICollection<DebitNote> DebitNotes { get; set; }
        public virtual ICollection<PurchaseReturnDetail> PurchaseReturnDetails { get; set; }
    }
}
