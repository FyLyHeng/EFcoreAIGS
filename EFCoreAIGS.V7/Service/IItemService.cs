using EFCoreAIGS.V7.Model;

namespace EFCoreAIGS.V7.Service
{
    public interface IItemService
    {
        public void Add();
        public List<Item> All();
    }
}
