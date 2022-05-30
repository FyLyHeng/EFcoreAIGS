using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Salutation
    {
        public Salutation()
        {
            Contacts = new HashSet<Contact>();
            Customers = new HashSet<Customer>();
            Employees = new HashSet<Employee>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string Salutation1 { get; set; } = null!;
        public long GenderId { get; set; }

        public virtual Gender Gender { get; set; } = null!;
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
