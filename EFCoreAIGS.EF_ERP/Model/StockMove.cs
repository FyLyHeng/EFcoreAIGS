using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class StockMove
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? IsRefund { get; set; }
        public float? ItemQty { get; set; }
        public string? Name { get; set; }
        public string? Note { get; set; }
        public int? StateStockMove { get; set; }
        public long? ItemId { get; set; }
        public long? WarehouseId { get; set; }

        public virtual Item? Item { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
    }
}
