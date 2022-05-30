using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class PurchaseItem
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? IsPurchaseItem { get; set; }
        public int? LeadTimeInDay { get; set; }
        public int? MinimumOrderQty { get; set; }
        public int? SafetyStock { get; set; }
        public long? ItemId { get; set; }
        public long? UomId { get; set; }

        public virtual Item? Item { get; set; }
        public virtual Uom? Uom { get; set; }
    }
}
