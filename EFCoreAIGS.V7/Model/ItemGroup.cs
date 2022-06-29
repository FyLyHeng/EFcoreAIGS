using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAIGS.V7.Model
{
    [EntityTypeConfiguration(typeof(ItemGroupConfig))]
    public class ItemGroup : BaseEntityUUID
    {
        public String Name { get; set; }
        //public virtual ICollection<Item>? Items { get; set; }
    }

    internal class ItemGroupConfig : BaseEntityTypeConfiguration<ItemGroup>
    {
        public override void Configure(EntityTypeBuilder<ItemGroup> builder)
        {
            base.Configure(builder);
            builder.Property(q => q.Name).HasDefaultValue("TEST UUID");
            
            builder.HasData(
                new ItemGroup {Id = Guid.Parse("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1"), Name = "Drink"},
                new ItemGroup {Id = Guid.Parse("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d2"), Name = "TEST-1"}
                );
        }
    }
}
