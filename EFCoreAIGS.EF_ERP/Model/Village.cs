using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Village
    {
        public Village()
        {
            Addresses = new HashSet<Address>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? CommuneCode { get; set; }
        public string? Village1 { get; set; }
        public string? Villid { get; set; }
        public string? VillageKh { get; set; }
        public long CommuneId { get; set; }

        public virtual Commune Commune { get; set; } = null!;
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
