using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class PurchaseReceipt
    {
        public PurchaseReceipt()
        {
            PurchaseInvoices = new HashSet<PurchaseInvoice>();
            PurchaseReceiptDetails = new HashSet<PurchaseReceiptDetail>();
            PurchaseReceiptExpanses = new HashSet<PurchaseReceiptExpanse>();
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
        public double? DiscountAmount { get; set; }
        public double? DiscountPercent { get; set; }
        public double GrandTotal { get; set; }
        public bool? IsReturn { get; set; }
        public string? Noted { get; set; }
        public string? ProrateBy { get; set; }
        public long? ProrateById { get; set; }
        public DateTime? PurchaseOrderDate { get; set; }
        public string? PurchaseOrderSeries { get; set; }
        public bool? RawMaterial { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string? Series { get; set; }
        public string? ShippingAddress { get; set; }
        public string? SupplierAddress { get; set; }
        public double TotalAdditionalAmount { get; set; }
        public double? TotalAmount { get; set; }
        public double? TotalCharge { get; set; }
        public double? TotalQty { get; set; }
        public double? TotalWeight { get; set; }
        public long? ContactId { get; set; }
        public long? CurrencyId { get; set; }
        public long? PriceListId { get; set; }
        public long? PurchaseOrderId { get; set; }
        public long? SupplierId { get; set; }
        public long? WarehouseId { get; set; }

        public virtual Contact? Contact { get; set; }
        public virtual Currency? Currency { get; set; }
        public virtual PriceList? PriceList { get; set; }
        public virtual PurchaseOrder? PurchaseOrder { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual ICollection<PurchaseReceiptDetail> PurchaseReceiptDetails { get; set; }
        public virtual ICollection<PurchaseReceiptExpanse> PurchaseReceiptExpanses { get; set; }
    }
}
