using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class SupplierPaymentReference
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public double? PaidAmount { get; set; }
        public double? PiAmount { get; set; }
        public string? PiNo { get; set; }
        public double? PoAmount { get; set; }
        public string? PoNo { get; set; }
        public double? PrePaidAmount { get; set; }
        public double? PrepaymentAmount { get; set; }
        public int? PurchaseInvoiceId { get; set; }
        public int? PurchaseOrderId { get; set; }
        public double? UnpaidAmount { get; set; }
        public long? SupplierPaymentId { get; set; }

        public virtual SupplierPayment? SupplierPayment { get; set; }
    }
}
