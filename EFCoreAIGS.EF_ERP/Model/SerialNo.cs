using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class SerialNo
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Asset { get; set; }
        public string? AssetStatus { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? DeliverySeries { get; set; }
        public string? Employee { get; set; }
        public string? MaintenanceStatus { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string? PurchaseSeries { get; set; }
        public string? SerialNo1 { get; set; }
        public string? SerialNoDetail { get; set; }
        public DateTime? WarrantyExpireDate { get; set; }
        public float? WarrantyPeriod { get; set; }
        public long? CustomerId { get; set; }
        public long? ItemId { get; set; }
        public long? SupplierId { get; set; }
        public long? WarehouseId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Item? Item { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
    }
}
