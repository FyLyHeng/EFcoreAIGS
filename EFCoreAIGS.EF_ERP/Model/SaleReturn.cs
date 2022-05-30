using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class SaleReturn
    {
        public SaleReturn()
        {
            SaleReturnDetails = new HashSet<SaleReturnDetail>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? CustomStatus { get; set; }
        public DateTime? Date { get; set; }
        public double? Discount { get; set; }
        public double? GrandTotal { get; set; }
        public string? Remark { get; set; }
        public string? ReturnFrom { get; set; }
        public string? Series { get; set; }
        public double? Total { get; set; }
        public double? TotalQty { get; set; }
        public long? CurrencyId { get; set; }
        public long? CustomerId { get; set; }
        public long? DeliveryNoteId { get; set; }
        public long? SaleOrderId { get; set; }
        public long? WarehouseId { get; set; }

        public virtual Currency? Currency { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual DeliveryNote? DeliveryNote { get; set; }
        public virtual SaleOrder? SaleOrder { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
        public virtual ICollection<SaleReturnDetail> SaleReturnDetails { get; set; }
    }
}
