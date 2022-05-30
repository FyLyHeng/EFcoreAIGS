using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class AccountClass
    {
        public AccountClass()
        {
            AccountSubClasses = new HashSet<AccountSubClass>();
            ChartOfAccounts = new HashSet<ChartOfAccount>();
        }

        public long Id { get; set; }
        public string? ClassName { get; set; }
        public long? BalanceSideId { get; set; }

        public virtual BalanceSide? BalanceSide { get; set; }
        public virtual ICollection<AccountSubClass> AccountSubClasses { get; set; }
        public virtual ICollection<ChartOfAccount> ChartOfAccounts { get; set; }
    }
}
