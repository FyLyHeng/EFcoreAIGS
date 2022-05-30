using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class BarcodeItem
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Barcode { get; set; }
        public long BarcodeTypeId { get; set; }
        public long? ItemId { get; set; }

        public virtual BarcodeType BarcodeType { get; set; } = null!;
        public virtual Item? Item { get; set; }
    }
}
