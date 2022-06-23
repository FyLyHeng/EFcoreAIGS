using EFCore.AIGS.SQLITE.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFCore.AIGS.SQLITE.Service
{
    public class ItemService
    {
        private static SQLiteContext repo = new SQLiteContext();


        public List<Item> All()
        {
            return repo.Item.AsNoTracking().Include(q=>q.ItemGroup).ToList();
        }

        public void Add()
        {

            var ig = new ItemGroup
            {
                //Id = Guid.NewGuid(),
                Name = "Coffee",
                Items = new List<Item>
                {
                    new Item{Name = "menu 1"},
                    new Item{Name = "menu 2"},
                    new Item{Name = "menu 3"}
                }
            };
            
            repo.ItemGroup.Add(ig);
            repo.SaveChanges();
        }
    }
}
