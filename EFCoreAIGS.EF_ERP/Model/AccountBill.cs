using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class AccountBill
    {
        public AccountBill()
        {
            AccountBillItems = new HashSet<AccountBillItem>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public DateTime? BillDate { get; set; }
        public string? BillRef { get; set; }
        public int? BillStatus { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public long? JournalEntryId { get; set; }
        public double? TotalBillAmount { get; set; }
        public long? ChartOfAccountId { get; set; }
        public long? BranchId { get; set; }
        public long? CurrencyId { get; set; }
        public long? SupplierId { get; set; }
        public long? TransactionTypeId { get; set; }
        public long? AccountBillId { get; set; }

        public virtual ClearBill? AccountBillNavigation { get; set; }
        public virtual Branch? Branch { get; set; }
        public virtual ChartOfAccount? ChartOfAccount { get; set; }
        public virtual Currency? Currency { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual TransactionType? TransactionType { get; set; }
        public virtual ICollection<AccountBillItem> AccountBillItems { get; set; }
    }
}
