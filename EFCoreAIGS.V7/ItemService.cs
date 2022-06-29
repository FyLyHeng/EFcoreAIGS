using EFCoreAIGS.V7.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAIGS.V7
{
    public class ItemService
    {
        private static V7Context repo = new V7Context();
        



        public List<Item> All()
        {
            return repo.Item.AsNoTracking().Include(q=>q.ItemGroup).ToList();
        }

        public void Add()
        {
            var gId = Guid.Parse("6d1710a0-e561-41d1-b250-fcad0c06a976");
            //repo.ItemGroup.Add(new ItemGroup{Id = gId, Name = "Me read"});
            //repo.SaveChanges();
            
            

            var ig = new Item
            {
                Id = Guid.NewGuid(),
                Name = "two test",
                ItemGroup = repo.ItemGroup.Single(q => q.Id == gId)
            };
            
            repo.Item.Add(ig);
            repo.SaveChanges();
        }
    }
}
