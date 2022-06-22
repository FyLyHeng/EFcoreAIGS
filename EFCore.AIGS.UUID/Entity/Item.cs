using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.AIGS.UUID.Entity
{
    [EntityTypeConfiguration(typeof(ItemConfig))]
    public class Item : BaseEntityUUID
    {
        public String Name { get; set; }
        public Guid? ItemGroupId { get; set; }
        public ItemGroup ItemGroup { get; set; }
    }

    [Flags]
    public enum ItemType
    {
        Drink = 12,
        Food,
        Alcohol
    }

    internal class ItemConfig : BaseEntityTypeConfiguration<Item>
    {
        public override void Configure(EntityTypeBuilder<Item> builder)
        {
            
            base.Configure(builder);
            builder.Property(q => q.Name).HasDefaultValue("Item TEST");

            builder.HasData(
                new Item {Id = Guid.Parse("95254799-131c-43a9-88c8-39865a39e61c"),Name = "Milk tea", ItemGroupId = Guid.Parse("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1")},
                new Item {Id = Guid.Parse("b2cc35e8-ed6e-4b24-a793-726844cf52d7"),Name = "Ice Coffee", ItemGroupId = Guid.Parse("d40e315c-06ac-4eb4-a66b-e78a8bbdd0d1")}
            );
        }
    }
}