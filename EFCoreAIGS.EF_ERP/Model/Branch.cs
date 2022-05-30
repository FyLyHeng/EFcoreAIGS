using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Branch
    {
        public Branch()
        {
            AccountBills = new HashSet<AccountBill>();
            ClearBills = new HashSet<ClearBill>();
            CoaBalances = new HashSet<CoaBalance>();
            JournalEntries = new HashSet<JournalEntry>();
            Users = new HashSet<User>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Abbr { get; set; }
        public string? Address { get; set; }
        public string? BranchCode { get; set; }
        public string? BranchName { get; set; }
        public string? BranchNameKh { get; set; }
        public string? CityProvince { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public virtual ICollection<AccountBill> AccountBills { get; set; }
        public virtual ICollection<ClearBill> ClearBills { get; set; }
        public virtual ICollection<CoaBalance> CoaBalances { get; set; }
        public virtual ICollection<JournalEntry> JournalEntries { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
