using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Commune
    {
        public Commune()
        {
            Addresses = new HashSet<Address>();
            Villages = new HashSet<Village>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Commune1 { get; set; }
        public string? Commid { get; set; }
        public string? CommuneKh { get; set; }
        public string? DistrictCode { get; set; }
        public long DistrictId { get; set; }

        public virtual District District { get; set; } = null!;
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Village> Villages { get; set; }
    }
}
