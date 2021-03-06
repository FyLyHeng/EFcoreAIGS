using EFCoreAIGS.sq_lite.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAIGS.sq_lite.Service
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

            var ig = new Item
            {
                Id = Guid.NewGuid(),
                Name = "two test",
                ItemGroup = repo.ItemGroup.Single(q => q.Id == Guid.Parse("D40E315C-06AC-4EB4-A66B-E78A8BBDD0D1"))
            };
            
            repo.Item.Add(ig);
            repo.SaveChanges();
        }
    }
}
