using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class SupplierPayment
    {
        public SupplierPayment()
        {
            SupplierPaymentReferences = new HashSet<SupplierPaymentReference>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? CustomStatus { get; set; }
        public bool? IsSettleCredit { get; set; }
        public double? PaidAmount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string? PaymentOption { get; set; }
        public string? PaymentType { get; set; }
        public string? RefNo { get; set; }
        public string? Remark { get; set; }
        public string? Series { get; set; }
        public double? SettlementAmount { get; set; }
        public double? TotalPaidAmount { get; set; }
        public long? GlAccountId { get; set; }
        public long? SupplierId { get; set; }

        public virtual ChartOfAccount? GlAccount { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual ICollection<SupplierPaymentReference> SupplierPaymentReferences { get; set; }
    }
}
