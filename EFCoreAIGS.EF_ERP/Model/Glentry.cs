using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Glentry
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public double? Credit { get; set; }
        public double? Debit { get; set; }
        public DateTime? PostingDate { get; set; }
        public string? Remark { get; set; }
        public string? VoucherNo { get; set; }
        public string? VoucherType { get; set; }
        public long? ChartOfAccId { get; set; }
        public long? CompanyId { get; set; }
        public long? CustomerId { get; set; }
        public long? SupplierId { get; set; }

        public virtual ChartOfAccount? ChartOfAcc { get; set; }
        public virtual Company? Company { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Supplier? Supplier { get; set; }
    }
}
