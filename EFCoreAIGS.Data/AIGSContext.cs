using EFCoreAIGS.Data.Configuration.AppConfig;
using EFCoreAIGS.Data.Configuration.EntityConfig;
using EFCoreAIGS.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCoreAIGS.Data
{
    public class AIGSContext : AuditConfig
    {
        public AIGSContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            //AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SpendingDetails> SpendingDetails { get; set; }
        public DbSet<Spend> Spend { get; set; }
        public DbSet<CreditCard> CreditCard { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                //.UseNpgsql(@$"{AppConfiguration.ConnectionString}")
                .UseNpgsql(@"Host=localhost;Username=postgres;Password=P@ssw0rd;Database=EFCore")
                .LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name}, LogLevel.Information)
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
            modelBuilder.ApplyConfiguration(new CreditCardConfig());
            modelBuilder.ApplyConfiguration(new SpendDetailCinfig());
            // modelBuilder.ApplyConfiguration(new EmployeeConfig());
        }
    }
}
