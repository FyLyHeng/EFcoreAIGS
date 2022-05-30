using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class District
    {
        public District()
        {
            Addresses = new HashSet<Address>();
            Communes = new HashSet<Commune>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? District1 { get; set; }
        public string? Distid { get; set; }
        public string? DistrictKh { get; set; }
        public string? ProvinceCode { get; set; }
        public long ProvinceId { get; set; }

        public virtual Province Province { get; set; } = null!;
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Commune> Communes { get; set; }
    }
}
