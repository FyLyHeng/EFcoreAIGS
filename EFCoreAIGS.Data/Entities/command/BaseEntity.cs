using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAIGS.Data.Entities.command
{
    public abstract class BaseEntity
    {
        [Required]
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? CreateBy { get; set; }
        public string? LastUpdateBy { get; set; }
        public bool Status { get; set; }
        
        [Timestamp]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public uint Version { get; set; }
    }
}
