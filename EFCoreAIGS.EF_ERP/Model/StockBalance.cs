using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class StockBalance
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? IsAbsoluteValue { get; set; }
        public float BalanceQty { get; set; }
        public double BalanceValue { get; set; }
        public double Cogs { get; set; }
        public float InQty { get; set; }
        public double InValue { get; set; }
        public float OutQty { get; set; }
        public float OutValue { get; set; }
        public float ReservedQty { get; set; }
        public double ValuationRate { get; set; }
        public float WaitingQty { get; set; }
        public long? CompanyId { get; set; }
        public long? ItemId { get; set; }
        public long? ItemBrandId { get; set; }
        public long? ItemGroupId { get; set; }
        public long? UomId { get; set; }
        public long? WarehouseId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Item? Item { get; set; }
        public virtual ItemBrand? ItemBrand { get; set; }
        public virtual ItemGroup? ItemGroup { get; set; }
        public virtual Uom? Uom { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
    }
}
