namespace EFCoreAIGS.erp.Entites
{
    public partial class Role
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Description { get; set; }
        public string? RoleName { get; set; }
        public string? BaseCustomStatus { get; set; }
        public string? BaseSeries { get; set; }
    }
}
