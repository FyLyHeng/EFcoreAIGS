using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class TransactionJournal
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public int? BStatus { get; set; }
        public double? Credit { get; set; }
        public double? Debit { get; set; }
        public string? GlCode { get; set; }
        public string? Ref { get; set; }
        public long? ChartOfAccId { get; set; }
        public long? JournalEntryId { get; set; }

        public virtual ChartOfAccount? ChartOfAcc { get; set; }
        public virtual JournalEntry? JournalEntry { get; set; }
    }
}
