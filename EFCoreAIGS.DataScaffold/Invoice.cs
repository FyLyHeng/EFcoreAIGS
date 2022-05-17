using System;
using System.Collections.Generic;

namespace EFCoreAIGS.DataScaffold
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? CustomerName { get; set; }
        public DateTime? Date { get; set; }
        public string? InvoiceNo { get; set; }
        public double GrandTotal { get; set; }
        public double SubTotal { get; set; }
        public double? VatAmount { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
