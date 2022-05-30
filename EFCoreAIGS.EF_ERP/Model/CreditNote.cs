using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class CreditNote
    {
        public CreditNote()
        {
            Refunds = new HashSet<Refund>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public double? CreditNoteAmount { get; set; }
        public string? CustomStatus { get; set; }
        public DateTime? Date { get; set; }
        public double? InvoiceAmount { get; set; }
        public bool? IsIncludeVat { get; set; }
        public string? Remark { get; set; }
        public string? Series { get; set; }
        public long? CustomerId { get; set; }
        public long? InvoiceId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Invoice? Invoice { get; set; }
        public virtual ICollection<Refund> Refunds { get; set; }
    }
}
