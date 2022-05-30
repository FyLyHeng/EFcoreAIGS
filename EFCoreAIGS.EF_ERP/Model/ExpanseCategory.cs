using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class ExpanseCategory
    {
        public ExpanseCategory()
        {
            PurchaseReceiptExpanses = new HashSet<PurchaseReceiptExpanse>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<PurchaseReceiptExpanse> PurchaseReceiptExpanses { get; set; }
    }
}
