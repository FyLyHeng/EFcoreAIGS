using System;
using System.Collections.Generic;

namespace EFCoreAIGS.DataScaffold
{
    public partial class Account
    {
        public Account()
        {
            Items = new HashSet<Item>();
        }

        public long Id { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
