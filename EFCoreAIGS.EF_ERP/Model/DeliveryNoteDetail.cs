using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class DeliveryNoteDetail
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool HasSerialNo { get; set; }
        public double? Amount { get; set; }
        public float? ConversionFactor { get; set; }
        public float? Discount { get; set; }
        public float? DiscountPercent { get; set; }
        public float? Qty { get; set; }
        public double? Rate { get; set; }
        public string? SerialNo { get; set; }
        public float? StockQty { get; set; }
        public long? DeliveryNoteId { get; set; }
        public long? ItemId { get; set; }
        public long? ItemVariantUomId { get; set; }

        public virtual DeliveryNote? DeliveryNote { get; set; }
        public virtual Item? Item { get; set; }
        public virtual ItemVarrantUom? ItemVariantUom { get; set; }
    }
}
