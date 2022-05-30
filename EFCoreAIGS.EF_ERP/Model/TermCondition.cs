using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class TermCondition
    {
        public TermCondition()
        {
            Companies = new HashSet<Company>();
            CustomerGroups = new HashSet<CustomerGroup>();
            Quotations = new HashSet<Quotation>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? IsDisable { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<CustomerGroup> CustomerGroups { get; set; }
        public virtual ICollection<Quotation> Quotations { get; set; }
    }
}
