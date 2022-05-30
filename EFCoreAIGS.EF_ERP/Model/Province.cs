using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Province
    {
        public Province()
        {
            Addresses = new HashSet<Address>();
            Districts = new HashSet<District>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Province1 { get; set; }
        public string? Provid { get; set; }
        public string? ProvinceKh { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}
