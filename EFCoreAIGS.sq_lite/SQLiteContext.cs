using System.Reflection;
using EFCoreAIGS.sq_lite.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCoreAIGS.sq_lite
{
    public class SQLiteContext : DbContext
    {
        public SQLiteContext()
        {}

        public DbSet<ItemGroup> ItemGroup { get; set; }
        public DbSet<Item> Item { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                // .UseSqlite("Filename=/Users/liza/Documents/SQLITE/pos.db", options =>
                // {
                //     options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                // });

                .UseSqlite(@"DataSource=/Users/liza/Documents/SQLITE/ig_pos.db;", options =>
                {
                    options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                });
            
            optionsBuilder
                .LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name}, LogLevel.Information)
                .EnableSensitiveDataLogging();
                
            

            
            optionsBuilder.UseSnakeCaseNamingConvention();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
