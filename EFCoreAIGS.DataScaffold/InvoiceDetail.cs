using System;
using System.Collections.Generic;

namespace EFCoreAIGS.DataScaffold
{
    public partial class InvoiceDetail
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public double? Price { get; set; }
        public int? Qty { get; set; }
        public long? InvoiceId { get; set; }
        public long? ItemId { get; set; }

        public virtual Invoice? Invoice { get; set; }
        public virtual Item? Item { get; set; }
    }
}
