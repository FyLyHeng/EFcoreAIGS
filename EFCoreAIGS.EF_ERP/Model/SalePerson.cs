using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class SalePerson
    {
        public SalePerson()
        {
            Customers = new HashSet<Customer>();
            InverseParent = new HashSet<SalePerson>();
            Quotations = new HashSet<Quotation>();
            SaleOrders = new HashSet<SaleOrder>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? Enabled { get; set; }
        public bool? IsGroup { get; set; }
        public float? CommissionRate { get; set; }
        public string? SalePersonName { get; set; }
        public long? EmployeeId { get; set; }
        public long? ParentId { get; set; }

        public virtual Employee? Employee { get; set; }
        public virtual SalePerson? Parent { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<SalePerson> InverseParent { get; set; }
        public virtual ICollection<Quotation> Quotations { get; set; }
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
    }
}
