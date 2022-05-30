using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class DocumentSetting
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Description { get; set; }
        public bool? IsDifferentPrefix { get; set; }
        public bool? IsDifferentSequence { get; set; }
        public int? LastCode { get; set; }
        public int? Length { get; set; }
        public string? Name { get; set; }
        public int? NonVatLastCode { get; set; }
        public string? NonVatPrefix { get; set; }
        public string? NonVatSuffix { get; set; }
        public string? Prefix { get; set; }
        public string? Suffix { get; set; }
    }
}
