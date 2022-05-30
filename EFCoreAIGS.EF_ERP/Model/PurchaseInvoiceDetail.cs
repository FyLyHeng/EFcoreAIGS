using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class PurchaseInvoiceDetail
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public double? ActualQty { get; set; }
        public double? Amount { get; set; }
        public float? ConversionFactor { get; set; }
        public double? DiscountAmount { get; set; }
        public double? DiscountPercent { get; set; }
        public string? ItemName { get; set; }
        public double? LastPurchaseRate { get; set; }
        public float? Qty { get; set; }
        public double? Rate { get; set; }
        public float? ReceivedQty { get; set; }
        public double? StockQty { get; set; }
        public double? WeightUom { get; set; }
        public long? ItemId { get; set; }
        public long? ItemVariantUomId { get; set; }
        public long? PurchaseInvoiceId { get; set; }

        public virtual Item? Item { get; set; }
        public virtual ItemVarrantUom? ItemVariantUom { get; set; }
        public virtual PurchaseInvoice? PurchaseInvoice { get; set; }
    }
}
