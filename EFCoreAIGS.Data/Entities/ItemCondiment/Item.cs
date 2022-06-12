using EFCoreAIGS.Data.Entities.command;

namespace EFCoreAIGS.Data.Entities.ItemCondiment
{
    public class Item : BaseEntity
    {
        public String? Name { get; set; }
        public double? Price { get; set; }
        public virtual ICollection<ItemCondiment> Condiments { get; set; }

    }
}
