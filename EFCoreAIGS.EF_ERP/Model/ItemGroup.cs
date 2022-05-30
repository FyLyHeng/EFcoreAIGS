using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class ItemGroup
    {
        public ItemGroup()
        {
            InverseParent = new HashSet<ItemGroup>();
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
        public bool? IsGroup { get; set; }
        public string GroupName { get; set; } = null!;
        public long? ParentId { get; set; }

        public virtual ItemGroup? Parent { get; set; }
        public virtual ICollection<ItemGroup> InverseParent { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<StockBalance> StockBalances { get; set; }
    }
}
