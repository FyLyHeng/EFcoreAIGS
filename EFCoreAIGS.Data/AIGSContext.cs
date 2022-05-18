using EFCoreAIGS.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCoreAIGS.Data
{
    public class AIGSContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<SpendingDetails> SpendingDetails { get; set; }
        public DbSet<Spend> Spend { get; set; }
        public DbSet<CreditCard> CreditCard { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql(@"Host=localhost;Username=postgres;Password=P@ssw0rd;Database=EFCore")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
            
            modelBuilder.Entity<SpendingDetails>()
                .HasMany(m => m.IncomeSpend)
                .WithOne(m => m.IncomeSpendingDetails)
                .HasForeignKey(m => m.IncomeSpendingDetailsId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<SpendingDetails>()
                .HasMany(m => m.OutcomeSpend)
                .WithOne(m => m.OutcomeSpendingDetails)
                .HasForeignKey(m => m.OutcomeSpendingDetailsId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CreditCard>()
                .HasOne(m => m.Employee)
                .WithOne(m => m.CreditCard)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
