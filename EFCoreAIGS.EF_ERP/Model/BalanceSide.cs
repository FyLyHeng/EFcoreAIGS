using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class BalanceSide
    {
        public BalanceSide()
        {
            AccountClasses = new HashSet<AccountClass>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<AccountClass> AccountClasses { get; set; }
    }
}
