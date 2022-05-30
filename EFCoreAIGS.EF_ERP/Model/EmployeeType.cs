using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            Employees = new HashSet<Employee>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? EmployeeType1 { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
