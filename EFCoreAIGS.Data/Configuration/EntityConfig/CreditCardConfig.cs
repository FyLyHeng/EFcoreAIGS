using EFCoreAIGS.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAIGS.Data.Configuration.EntityConfig
{
    public class CreditCardConfig : IEntityTypeConfiguration<CreditCard>
    {

        public void Configure(EntityTypeBuilder<CreditCard> builder)
        {
            //Map 1-to-1 Relationship
            builder
                .HasOne(m => m.Employee)
                .WithOne(m => m.CreditCard)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
