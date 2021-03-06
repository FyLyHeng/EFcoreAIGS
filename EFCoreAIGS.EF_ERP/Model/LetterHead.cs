using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class LetterHead
    {
        public LetterHead()
        {
            Companies = new HashSet<Company>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? LetterHeadName { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
