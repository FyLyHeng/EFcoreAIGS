using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class SupplierGroup
    {
        public SupplierGroup()
        {
            InverseParent = new HashSet<SupplierGroup>();
            Suppliers = new HashSet<Supplier>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? IsGroup { get; set; }
        public string GroupName { get; set; } = null!;
        public long? ParentId { get; set; }

        public virtual SupplierGroup? Parent { get; set; }
        public virtual ICollection<SupplierGroup> InverseParent { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
