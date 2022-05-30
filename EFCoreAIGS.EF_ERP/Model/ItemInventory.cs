using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class ItemInventory
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public DateTime? EndOfLife { get; set; }
        public long? SelfLifeInDay { get; set; }
        public long? WarrantyPeriod { get; set; }
        public double? WeightPerUnit { get; set; }
        public string? WeightUom { get; set; }
        public long? ItemId { get; set; }
        public long? MaterialRequestTypeId { get; set; }
        public long? UomId { get; set; }
        public long? ValuationMethodId { get; set; }

        public virtual Item? Item { get; set; }
        public virtual MaterialRequestType? MaterialRequestType { get; set; }
        public virtual Uom? Uom { get; set; }
        public virtual ValuationMethod? ValuationMethod { get; set; }
    }
}
