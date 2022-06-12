using EFCoreAIGS.Data.Entities.command;

namespace EFCoreAIGS.Data.Entities.ItemCondiment
{
    public class Condiment : BaseEntity
    {
        public String Name { get; set; }
        public virtual ICollection<ItemCondiment> Items { get; set; }
    }
}
