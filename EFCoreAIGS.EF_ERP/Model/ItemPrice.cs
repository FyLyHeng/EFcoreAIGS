using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class ItemPrice
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? IsBuying { get; set; }
        public bool? IsSelling { get; set; }
        public int? MinimumQty { get; set; }
        public string? Note { get; set; }
        public double? Rate { get; set; }
        public double? StandardBuying { get; set; }
        public double? StandardSelling { get; set; }
        public long? CurrencyId { get; set; }
        public long ItemId { get; set; }
        public long? PriceListId { get; set; }

        public virtual Currency? Currency { get; set; }
        public virtual Item Item { get; set; } = null!;
        public virtual PriceList? PriceList { get; set; }
    }
}
