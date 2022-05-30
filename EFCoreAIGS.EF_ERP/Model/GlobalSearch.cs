using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class GlobalSearch
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Description { get; set; }
        public string DocType { get; set; } = null!;
        public string Routing { get; set; } = null!;
        public long? TargetId { get; set; }
        public string Title { get; set; } = null!;
    }
}
