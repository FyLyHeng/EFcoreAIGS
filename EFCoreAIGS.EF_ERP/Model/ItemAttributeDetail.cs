using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class ItemAttributeDetail
    {
        public ItemAttributeDetail()
        {
            ItemAttributeValues = new HashSet<ItemAttributeValue>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Abbreviation { get; set; }
        public string? AttributeValue { get; set; }
        public long? ItemAttributeId { get; set; }

        public virtual ItemAttribute? ItemAttribute { get; set; }
        public virtual ICollection<ItemAttributeValue> ItemAttributeValues { get; set; }
    }
}
