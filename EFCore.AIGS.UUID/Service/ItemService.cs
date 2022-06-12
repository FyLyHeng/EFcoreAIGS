using EFCore.AIGS.UUID.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFCore.AIGS.UUID.Service
{
    public class ItemService
    {
        private static UuidContext repo = new UuidContext();


        public List<Item> All()
        {
            return repo.Item.AsNoTracking().Include(q=>q.ItemGroup).ToList();
        }

        public void Add()
        {

            var ig = new ItemGroup
            {
                Name = "Coffee",
                Items = new List<Item>
                {
                    new Item{Name = "Hot Latte"},
                    new Item{Name = "Ice Latte"},
                }
            };
            
            repo.ItemGroup.Add(ig);
            repo.SaveChanges();
        }
    }
}
