using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class JournalEntry
    {
        public JournalEntry()
        {
            TransactionJournals = new HashSet<TransactionJournal>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? Adjusting { get; set; }
        public int? BStatus { get; set; }
        public bool? CanReverse { get; set; }
        public string? Description { get; set; }
        public string? EntryNo { get; set; }
        public DateTime? JournalDate { get; set; }
        public int? JournalType { get; set; }
        public double? TotalCredit { get; set; }
        public double? TotalDebit { get; set; }
        public long? BranchId { get; set; }
        public long? CurrencyId { get; set; }
        public long? TrxnTypeId { get; set; }

        public virtual Branch? Branch { get; set; }
        public virtual Currency? Currency { get; set; }
        public virtual TransactionType? TrxnType { get; set; }
        public virtual ICollection<TransactionJournal> TransactionJournals { get; set; }
    }
}
