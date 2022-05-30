using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            PurchaseInvoices = new HashSet<PurchaseInvoice>();
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
            PurchaseReceipts = new HashSet<PurchaseReceipt>();
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
        public double GrandTotal { get; set; }
        public double OutstandingAmount { get; set; }
        public double PrePaidAmount { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string? Series { get; set; }
        public double TotalAmount { get; set; }
        public double? TotalCharge { get; set; }
        public double TotalPrepayment { get; set; }
        public double? TotalQty { get; set; }
        public double? TotalWeight { get; set; }
        public long? ContactId { get; set; }
        public long? CurrencyId { get; set; }
        public long? PriceListId { get; set; }
        public long? SupplierId { get; set; }
        public long? WarehouseId { get; set; }

        public virtual Contact? Contact { get; set; }
        public virtual Currency? Currency { get; set; }
        public virtual PriceList? PriceList { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual ICollection<PurchaseReceipt> PurchaseReceipts { get; set; }
    }
}
