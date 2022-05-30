using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class CustomerPrePayment
    {
        public CustomerPrePayment()
        {
            CustomerPrePaymentReferences = new HashSet<CustomerPrePaymentReference>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public double? Amount { get; set; }
        public string? CustomStatus { get; set; }
        public bool? IsByso { get; set; }
        public double? LastPrepaymentBalance { get; set; }
        public string? PayBy { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string? PaymentOption { get; set; }
        public string? RefNo { get; set; }
        public string? Remark { get; set; }
        public string? Series { get; set; }
        public long? CustomerId { get; set; }
        public long? GlAccountId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual ChartOfAccount? GlAccount { get; set; }
        public virtual ICollection<CustomerPrePaymentReference> CustomerPrePaymentReferences { get; set; }
    }
}
