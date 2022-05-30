using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class ItemBrand
    {
        public ItemBrand()
        {
            Items = new HashSet<Item>();
            StockBalances = new HashSet<StockBalance>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string BrandName { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<StockBalance> StockBalances { get; set; }
    }
}
