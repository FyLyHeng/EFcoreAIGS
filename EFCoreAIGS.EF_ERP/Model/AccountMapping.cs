using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class AccountMapping
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Name { get; set; }
        public long? ChartOfAccId { get; set; }
        public long? TrxnTypeId { get; set; }

        public virtual ChartOfAccount? ChartOfAcc { get; set; }
        public virtual TransactionType? TrxnType { get; set; }
    }
}
