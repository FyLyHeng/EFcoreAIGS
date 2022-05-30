using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Invoice
    {
        public Invoice()
        {
            CreditNotes = new HashSet<CreditNote>();
            InvoiceDetails = new HashSet<InvoiceDetail>();
            Refunds = new HashSet<Refund>();
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
        public string? CustomStatus { get; set; }
        public DateTime? DueDate { get; set; }
        public float? GrandTotal { get; set; }
        public double? InvoiceAmount { get; set; }
        public float? InvoicePer { get; set; }
        public bool? IsIncludeVat { get; set; }
        public string? Series { get; set; }
        public string? ShippingAddress { get; set; }
        public double? Total { get; set; }
        public double? TotalCost { get; set; }
        public float? TotalQty { get; set; }
        public float? UnpaidAmount { get; set; }
        public double? VatAmount { get; set; }
        public float? VatPer { get; set; }
        public string? WarehouseAddress { get; set; }
        public long? CustomerId { get; set; }
        public long? DeliveryNoteId { get; set; }
        public long? SaleOrderId { get; set; }
        public long? WarehouseId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual DeliveryNote? DeliveryNote { get; set; }
        public virtual SaleOrder? SaleOrder { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
        public virtual ICollection<CreditNote> CreditNotes { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<Refund> Refunds { get; set; }
    }
}
