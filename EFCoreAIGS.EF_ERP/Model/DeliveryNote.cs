using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class DeliveryNote
    {
        public DeliveryNote()
        {
            DeliveryNoteDetails = new HashSet<DeliveryNoteDetail>();
            Invoices = new HashSet<Invoice>();
            SaleReturns = new HashSet<SaleReturn>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public double? AdditionalDisAmount { get; set; }
        public float? AdditionalDisPer { get; set; }
        public string? BillingAddress { get; set; }
        public int? BillingAddressId { get; set; }
        public string? BillingTitle { get; set; }
        public string? CustomStatus { get; set; }
        public DateTime? DateDone { get; set; }
        public double? GrandTotal { get; set; }
        public bool? ImmediateTransfer { get; set; }
        public string? Note { get; set; }
        public int? Priority { get; set; }
        public string? Series { get; set; }
        public string? ShippingAddress { get; set; }
        public int? ShippingAddressId { get; set; }
        public string? ShippingTitle { get; set; }
        public double? Total { get; set; }
        public int? TotalQty { get; set; }
        public double? VatAmount { get; set; }
        public float? VatPer { get; set; }
        public string? WarehouseAddress { get; set; }
        public long? CustomerId { get; set; }
        public long? DeliveryTypeId { get; set; }
        public long? DriverId { get; set; }
        public long? SaleOrderId { get; set; }
        public long? WarehouseId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual DeliveryType? DeliveryType { get; set; }
        public virtual Driver? Driver { get; set; }
        public virtual SaleOrder? SaleOrder { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
        public virtual ICollection<DeliveryNoteDetail> DeliveryNoteDetails { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<SaleReturn> SaleReturns { get; set; }
    }
}
