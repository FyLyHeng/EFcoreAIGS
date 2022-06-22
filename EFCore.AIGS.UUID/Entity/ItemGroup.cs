using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.AIGS.UUID.Entity
{
    [EntityTypeConfiguration(typeof(ItemGroupConfig))]
    public class ItemGroup : BaseEntityUUID
    {
        public String Name { get; set; }
        public virtual ICollection<Item>? Items { get; set; }
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
            
            
            // var itemGroup = new ItemGroup {Id = Guid.Parse("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d3"), Name = "Cake"};
            //
            // builder.HasData(itemGroup);
            // builder.OwnsMany(q => q.Items).HasData(
            //     new {Id = Guid.Parse("585d99d4-a9b5-4e0a-b271-5d28854879a8"),Name = "HBD cake",ItemGroupId = itemGroup.Id},
            //     new {Id = Guid.Parse("93f4d1c9-8c0f-406a-8b8c-40ef15178e8b"),Name = "Broken cake",ItemGroupId = itemGroup.Id}
            // );
        }
    }
}
