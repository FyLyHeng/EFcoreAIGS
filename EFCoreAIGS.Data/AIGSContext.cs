using EFCoreAIGS.Data.Configuration.AppConfig;
using EFCoreAIGS.Data.Configuration.EntityConfig;
using EFCoreAIGS.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EFCoreAIGS.Data
{
    public class AIGSContext : AuditConfig
    {

        private static IConfigurationRoot _configuration;        
        public AIGSContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            //AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        public AIGSContext(DbContextOptions<AIGSContext> options) : base(options)
        {
        }
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SpendingDetails> SpendingDetails { get; set; }
        public DbSet<Spend> Spend { get; set; }
        public DbSet<CreditCard> CreditCard { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql(@$"{AppConfiguration.ConnectionString}")
                .LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name}, LogLevel.Information)
                .EnableSensitiveDataLogging();

            optionsBuilder.UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
            modelBuilder.ApplyConfiguration(new CreditCardConfig());
            modelBuilder.ApplyConfiguration(new SpendDetailCinfig());
            // modelBuilder.ApplyConfiguration(new EmployeeConfig());
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<String>()
                .HaveMaxLength(255);

            configurationBuilder.Properties<double>()
                .HavePrecision(10, 3);

            //base.ConfigureConventions(configurationBuilder);
        }
    }
}
