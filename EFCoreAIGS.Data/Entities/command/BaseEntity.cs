namespace EFCoreAIGS.Data.Entities.command
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? CreateBy { get; set; }
        public string? LastUpdateBy { get; set; }
    }
}
