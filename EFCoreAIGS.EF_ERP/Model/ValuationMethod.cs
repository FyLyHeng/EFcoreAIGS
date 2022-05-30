using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class ValuationMethod
    {
        public ValuationMethod()
        {
            ItemInventories = new HashSet<ItemInventory>();
            Items = new HashSet<Item>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? MethodName { get; set; }

        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
