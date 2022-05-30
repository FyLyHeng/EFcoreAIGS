using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class ItemAttributeValue
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public long ItemAttributeId { get; set; }
        public long ItemAttributeDetailId { get; set; }
        public long? ItemItemId { get; set; }

        public virtual ItemAttribute ItemAttribute { get; set; } = null!;
        public virtual ItemAttributeDetail ItemAttributeDetail { get; set; } = null!;
        public virtual ItemItem? ItemItem { get; set; }
    }
}
