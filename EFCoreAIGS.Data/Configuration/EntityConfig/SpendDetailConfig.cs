using EFCoreAIGS.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAIGS.Data.Configuration.EntityConfig
{
    public class SpendDetailCinfig : IEntityTypeConfiguration<SpendingDetails>
    {
        public void Configure(EntityTypeBuilder<SpendingDetails> builder)
        {
            //Map Many-to-Many Relationship
            builder
                .HasMany(m => m.IncomeSpend)
                .WithOne(m => m.IncomeSpendingDetails)
                .HasForeignKey(m => m.IncomeSpendingDetailsId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(m => m.OutcomeSpend)
                .WithOne(m => m.OutcomeSpendingDetails)
                .HasForeignKey(m => m.OutcomeSpendingDetailsId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
