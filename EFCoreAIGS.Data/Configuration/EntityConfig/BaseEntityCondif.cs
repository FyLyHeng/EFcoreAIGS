using EFCoreAIGS.Data.Entities.command;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAIGS.Data.Configuration.EntityConfig
{
    public class BaseEntityCondif : IEntityTypeConfiguration<BaseEntity>
    {
        public void Configure(EntityTypeBuilder<BaseEntity> entity)
            {
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Version).HasColumnName("version").IsRowVersion().HasConversion<int>();

                entity.Property(e => e.LastUpdateBy).HasColumnName("updated_by_id");
                entity.Property(e => e.CreateBy).HasColumnName("created_by_id");
            
                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");
            }
    }
}
