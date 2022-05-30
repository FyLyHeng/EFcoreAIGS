using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class SaleTaxCharge
    {
        public SaleTaxCharge()
        {
            SaleTaxDetails = new HashSet<SaleTaxDetail>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? Disable { get; set; }
        public string? Title { get; set; }
        public long? CompanyId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual ICollection<SaleTaxDetail> SaleTaxDetails { get; set; }
    }
}
