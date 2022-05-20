namespace EFCoreAIGS.erp.Entites
{
    public partial class User
    {
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
        public string? BaseCustomStatus { get; set; }
        public string? BaseSeries { get; set; }
    }
}
