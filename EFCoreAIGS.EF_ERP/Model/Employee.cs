using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Employee
    {
        public Employee()
        {
            Drivers = new HashSet<Driver>();
            SalePeople = new HashSet<SalePerson>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public DateTime? DataOfJoining { get; set; }
        public DateTime? Dob { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? Phone { get; set; }
        public string? Series { get; set; }
        public long? CompanyId { get; set; }
        public long? EmployeeTypeId { get; set; }
        public long? GenderId { get; set; }
        public long? HealthInsuranceId { get; set; }
        public long? SalutationId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual EmployeeType? EmployeeType { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual HealthInsurance? HealthInsurance { get; set; }
        public virtual Salutation? Salutation { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
        public virtual ICollection<SalePerson> SalePeople { get; set; }
    }
}
