using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class User
    {
        public User()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool IsAdmin { get; set; }
        public string? Email { get; set; }
        public string? ImagePath { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public string? Username { get; set; }
        public long? BranchId { get; set; }

        public virtual Branch? Branch { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
