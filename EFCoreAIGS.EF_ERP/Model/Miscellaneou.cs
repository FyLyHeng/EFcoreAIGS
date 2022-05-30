using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Miscellaneou
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public bool IsDefault { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
    }
}
