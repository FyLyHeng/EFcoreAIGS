using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Uom
    {
        public Uom()
        {
            ItemInventories = new HashSet<ItemInventory>();
            ItemVarrantUoms = new HashSet<ItemVarrantUom>();
            Items = new HashSet<Item>();
            PurchaseItems = new HashSet<PurchaseItem>();
            StockBalances = new HashSet<StockBalance>();
            StockLedgerEntries = new HashSet<StockLedgerEntry>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Name { get; set; }
        public bool? IsUsed { get; set; }

        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<ItemVarrantUom> ItemVarrantUoms { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<PurchaseItem> PurchaseItems { get; set; }
        public virtual ICollection<StockBalance> StockBalances { get; set; }
        public virtual ICollection<StockLedgerEntry> StockLedgerEntries { get; set; }
    }
}
