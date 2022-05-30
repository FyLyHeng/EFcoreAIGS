using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class RoleMenu
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public long MenuItemId { get; set; }
        public long RoleId { get; set; }

        public virtual MenuItem MenuItem { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;
    }
}
