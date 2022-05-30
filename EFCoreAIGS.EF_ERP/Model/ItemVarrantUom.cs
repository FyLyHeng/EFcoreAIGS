using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class ItemVarrantUom
    {
        public ItemVarrantUom()
        {
            DeliveryNoteDetails = new HashSet<DeliveryNoteDetail>();
            InvoiceDetails = new HashSet<InvoiceDetail>();
            PurchaseInvoiceDetails = new HashSet<PurchaseInvoiceDetail>();
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
            PurchaseReceiptDetails = new HashSet<PurchaseReceiptDetail>();
            PurchaseReturnDetails = new HashSet<PurchaseReturnDetail>();
            QuotationDetails = new HashSet<QuotationDetail>();
            SaleOrderDetails = new HashSet<SaleOrderDetail>();
            SaleReturnDetails = new HashSet<SaleReturnDetail>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public float? ConversionFactor { get; set; }
        public long? ItemId { get; set; }
        public long? UomId { get; set; }

        public virtual Item? Item { get; set; }
        public virtual Uom? Uom { get; set; }
        public virtual ICollection<DeliveryNoteDetail> DeliveryNoteDetails { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual ICollection<PurchaseReceiptDetail> PurchaseReceiptDetails { get; set; }
        public virtual ICollection<PurchaseReturnDetail> PurchaseReturnDetails { get; set; }
        public virtual ICollection<QuotationDetail> QuotationDetails { get; set; }
        public virtual ICollection<SaleOrderDetail> SaleOrderDetails { get; set; }
        public virtual ICollection<SaleReturnDetail> SaleReturnDetails { get; set; }
    }
}
