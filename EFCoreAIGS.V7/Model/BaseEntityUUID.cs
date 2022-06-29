using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAIGS.V7.Model
{
    public class BaseEntityUUID
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? Id { get; set; }

        public bool Status { get; set; }
    }

    public abstract class BaseEntityTypeConfiguration<TBase> : IEntityTypeConfiguration<TBase> where TBase : BaseEntityUUID
    {
        public virtual void Configure(EntityTypeBuilder<TBase> builder)
        {
            builder.Property(q => q.Status).HasDefaultValue(true);
        }
    }
}
