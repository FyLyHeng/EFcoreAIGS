using System;
using System.Collections.Generic;

namespace EFCoreAIGS.DataScaffold
{
    public partial class Category
    {
        public Category()
        {
            Items = new HashSet<Item>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
