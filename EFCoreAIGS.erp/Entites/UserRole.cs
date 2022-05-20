namespace EFCoreAIGS.erp.Entites 
{
    public partial class UserRole
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public long RoleId { get; set; }
        public long UserId { get; set; }
        public string? BaseCustomStatus { get; set; }
        public string? BaseSeries { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
