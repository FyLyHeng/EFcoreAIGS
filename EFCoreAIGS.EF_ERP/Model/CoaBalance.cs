using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class CoaBalance
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public double? Balance { get; set; }
        public string? GlCode { get; set; }
        public long? BranchId { get; set; }
        public long? ChartOfAccountId { get; set; }
        public long? CurrencyId { get; set; }

        public virtual Branch? Branch { get; set; }
        public virtual ChartOfAccount? ChartOfAccount { get; set; }
        public virtual Currency? Currency { get; set; }
    }
}
