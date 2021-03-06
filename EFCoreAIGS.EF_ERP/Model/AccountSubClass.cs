using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class AccountSubClass
    {
        public AccountSubClass()
        {
            ChartOfAccounts = new HashSet<ChartOfAccount>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? SubClassName { get; set; }
        public long? AccountClassId { get; set; }

        public virtual AccountClass? AccountClass { get; set; }
        public virtual ICollection<ChartOfAccount> ChartOfAccounts { get; set; }
    }
}
