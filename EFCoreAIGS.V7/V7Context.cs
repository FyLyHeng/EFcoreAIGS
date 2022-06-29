using System.Reflection;
using EFCoreAIGS.V7.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCoreAIGS.V7
{
    public class V7Context : DbContext
    {
        public DbSet<ItemGroup> ItemGroup { get; set; }
        public DbSet<Item> Item { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlite(@"DataSource=/Users/liza/Documents/SQLITE/ig_test.db;", options =>
                {
                    options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                });
            
            optionsBuilder
                .LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name}, LogLevel.Information)
                .EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
