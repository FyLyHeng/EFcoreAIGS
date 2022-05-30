using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Permission
    {
        public Permission()
        {
            RolePermissions = new HashSet<RolePermission>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string FunctionName { get; set; } = null!;
        public int FunctionOrder { get; set; }
        public long FeatureId { get; set; }

        public virtual Feature Feature { get; set; } = null!;
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
