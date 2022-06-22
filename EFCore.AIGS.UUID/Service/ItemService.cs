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
                    new Item{Name = "menu 1"},
                    new Item{Name = "menu 2"},
                    new Item{Name = "menu 3"},
                    new Item{Name = "menu 4"},
                    new Item{Name = "menu 5"},
                    new Item{Name = "menu 6"},
                    new Item{Name = "menu 7"},
                    new Item{Name = "menu 8"},
                    new Item{Name = "menu 9"},
                    new Item{Name = "menu 00"},
                    new Item{Name = "menu 01"},
                }
            };
            
            repo.ItemGroup.Add(ig);
            repo.SaveChanges();
        }
    }
}
