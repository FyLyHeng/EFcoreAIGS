using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Driver
    {
        public Driver()
        {
            DeliveryNotes = new HashSet<DeliveryNote>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? CellphoneNumber { get; set; }
        public string? DriverName { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? IssuingDate { get; set; }
        public string? LicenseNumber { get; set; }
        public string? Series { get; set; }
        public long? DriverStatusId { get; set; }
        public long? EmployeeId { get; set; }

        public virtual DriverStatus? DriverStatus { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual ICollection<DeliveryNote> DeliveryNotes { get; set; }
    }
}
