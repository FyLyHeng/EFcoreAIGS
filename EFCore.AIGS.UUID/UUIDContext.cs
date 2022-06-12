using EFCore.AIGS.UUID.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCore.AIGS.UUID
{
    public class UuidContext : DbContext
    {

        public UuidContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        public DbSet<ItemGroup> ItemGroup { get; set; }
        public DbSet<Item> Item { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                //.UseNpgsql(@$"{AppConfiguration.ConnectionString}")
                .UseNpgsql(@"Host=localhost;Username=postgres;Password=P@ssw0rd;Database=EFCore_uuid")
                .LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name}, LogLevel.Information)
                .EnableSensitiveDataLogging();

            optionsBuilder.UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasPostgresExtension("uuid-ossp");
        }
    }
}
