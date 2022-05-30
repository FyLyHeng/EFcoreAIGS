using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class PurchaseInvoice
    {
        public PurchaseInvoice()
        {
            PurchaseInvoiceDetails = new HashSet<PurchaseInvoiceDetail>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? CustomStatus { get; set; }
        public DateTime? DateDone { get; set; }
        public double DiscountAmount { get; set; }
        public double DiscountPercent { get; set; }
        public double GrandTotal { get; set; }
        public bool IsPaid { get; set; }
        public bool IsRawMaterial { get; set; }
        public bool IsReturn { get; set; }
        public string? Noted { get; set; }
        public double OutstandingAmount { get; set; }
        public double PrepaidAmount { get; set; }
        public double PrepaymentAmount { get; set; }
        public DateTime? PurchaseOrderDate { get; set; }
        public string? PurchaseOrderSeries { get; set; }
        public string? PurchaseReceiptSeries { get; set; }
        public string? Series { get; set; }
        public string? SupplierAddress { get; set; }
        public string? SupplierName { get; set; }
        public double TotalAmount { get; set; }
        public double TotalQty { get; set; }
        public double? TotalWeight { get; set; }
        public long? CurrencyId { get; set; }
        public long? PurchaseOrderId { get; set; }
        public long? PurchaseReceiptId { get; set; }
        public long? SupplierId { get; set; }
        public long? WarehouseId { get; set; }

        public virtual Currency? Currency { get; set; }
        public virtual PurchaseOrder? PurchaseOrder { get; set; }
        public virtual PurchaseReceipt? PurchaseReceipt { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
        public virtual ICollection<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }
    }
}
