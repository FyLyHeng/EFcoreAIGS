using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class ClearBill
    {
        public ClearBill()
        {
            AccountBills = new HashSet<AccountBill>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? BillClearStatus { get; set; }
        public string? BillRef { get; set; }
        public string? Checks { get; set; }
        public double? ClearAmount { get; set; }
        public DateTime? ClearDate { get; set; }
        public string? ClearRef { get; set; }
        public string? Description { get; set; }
        public long? JournalEntryId { get; set; }
        public long? BranchId { get; set; }
        public long? ChartOfAccountId { get; set; }
        public long? CurrencyId { get; set; }
        public long? PaymentMethodId { get; set; }
        public long? TransactionTypeId { get; set; }

        public virtual Branch? Branch { get; set; }
        public virtual ChartOfAccount? ChartOfAccount { get; set; }
        public virtual Currency? Currency { get; set; }
        public virtual PaymentMethod? PaymentMethod { get; set; }
        public virtual TransactionType? TransactionType { get; set; }
        public virtual ICollection<AccountBill> AccountBills { get; set; }
    }
}
