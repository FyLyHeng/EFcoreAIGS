using System.Reflection;
using EFCore.AIGS.SQLITE.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFCore.AIGS.SQLITE
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
                
            

            
            optionsBuilder.UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.HasPostgresExtension("uuid-ossp");
        }
    }
}
