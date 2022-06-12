using EFCoreAIGS.Data.Entities.command;

namespace EFCoreAIGS.Data.Entities.ItemCondiment
{
    public class ItemCondiment : BaseEntity
    {
        public long ItemId { get; set; }
        public long CondimentId { get; set; }
        
        public Item Item { get; set; }
        public Condiment Condiment { get; set; }
        
    }
}
