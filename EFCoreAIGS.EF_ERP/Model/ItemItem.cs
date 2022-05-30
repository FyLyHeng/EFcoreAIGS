using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class ItemItem
    {
        public ItemItem()
        {
            ItemAttributeValues = new HashSet<ItemAttributeValue>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Barcode { get; set; }
        public double? ExtraCost { get; set; }
        public double? ExtraPrice { get; set; }
        public double? ExtraPriceList { get; set; }
        public int? ItemQtyForecast { get; set; }
        public int? ItemQtyOnHand { get; set; }
        public long? ItemId { get; set; }

        public virtual Item? Item { get; set; }
        public virtual ICollection<ItemAttributeValue> ItemAttributeValues { get; set; }
    }
}
