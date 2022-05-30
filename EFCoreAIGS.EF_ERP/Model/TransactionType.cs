using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            AccountBills = new HashSet<AccountBill>();
            AccountMappings = new HashSet<AccountMapping>();
            ClearBills = new HashSet<ClearBill>();
            JournalEntries = new HashSet<JournalEntry>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Code { get; set; }
        public string? TrxnName { get; set; }

        public virtual ICollection<AccountBill> AccountBills { get; set; }
        public virtual ICollection<AccountMapping> AccountMappings { get; set; }
        public virtual ICollection<ClearBill> ClearBills { get; set; }
        public virtual ICollection<JournalEntry> JournalEntries { get; set; }
    }
}
