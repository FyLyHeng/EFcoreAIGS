using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class MenuItem
    {
        public MenuItem()
        {
            RoleMenus = new HashSet<RoleMenu>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool IsActive { get; set; }
        public bool IsDisable { get; set; }
        public bool IsGroupTitle { get; set; }
        public bool? Closable { get; set; }
        public string? Color { get; set; }
        public string? ExternalLink { get; set; }
        public string? IconClass { get; set; }
        public string? IconBg { get; set; }
        public string? IconColor { get; set; }
        public int? MenuOrder { get; set; }
        public long? ParentId { get; set; }
        public string? Routing { get; set; }
        public bool? Selected { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<RoleMenu> RoleMenus { get; set; }
    }
}
