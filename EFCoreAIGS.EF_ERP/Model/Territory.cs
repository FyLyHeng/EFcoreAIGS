using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Territory
    {
        public Territory()
        {
            Customers = new HashSet<Customer>();
            InverseParent = new HashSet<Territory>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? IsGroup { get; set; }
        public string? TerritoryName { get; set; }
        public long? ParentId { get; set; }

        public virtual Territory? Parent { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Territory> InverseParent { get; set; }
    }
}
