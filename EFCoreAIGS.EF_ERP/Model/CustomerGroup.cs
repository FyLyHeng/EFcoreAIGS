using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class CustomerGroup
    {
        public CustomerGroup()
        {
            Customers = new HashSet<Customer>();
            InverseParent = new HashSet<CustomerGroup>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? IsGroup { get; set; }
        public double? CreditLimit { get; set; }
        public string GroupName { get; set; } = null!;
        public long? ParentId { get; set; }
        public long? PriceListId { get; set; }
        public long? TermConditionId { get; set; }

        public virtual CustomerGroup? Parent { get; set; }
        public virtual PriceList? PriceList { get; set; }
        public virtual TermCondition? TermCondition { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<CustomerGroup> InverseParent { get; set; }
    }
}
