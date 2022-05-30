using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class ItemWarehouse
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public long CompanyId { get; set; }
        public long ItemId { get; set; }
        public long? PriceListId { get; set; }
        public long? WarehouseId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual Item Item { get; set; } = null!;
        public virtual PriceList? PriceList { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
    }
}
