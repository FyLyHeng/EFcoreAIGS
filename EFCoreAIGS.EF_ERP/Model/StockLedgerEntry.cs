using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class StockLedgerEntry
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public float? ActualQty { get; set; }
        public float? QtyAfterTranx { get; set; }
        public string? SerialNo { get; set; }
        public float? ValuationRate { get; set; }
        public string? VoucherNo { get; set; }
        public string? VoucherType { get; set; }
        public long? ItemId { get; set; }
        public long? UomId { get; set; }
        public long? WarehouseId { get; set; }

        public virtual Item? Item { get; set; }
        public virtual Uom? Uom { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
    }
}
