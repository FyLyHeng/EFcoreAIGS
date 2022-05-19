using EFCoreAIGS.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAIGS.Data.Configuration.EntityConfig
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            builder.HasIndex(q => q.Id).IsUnique();

            // builder.Property(q => new
            // {
            //     q.FirstName,
            //     q.LastName
            // }).HasMaxLength(50);

            builder.HasData(
                new Employee
                {
                    Id = 1,
                    FirstName = "default first name",
                    LastName = "default last name"
                    //Hired = new DateTime().AddDays(1) //sth want wrong when run migrate-update-database
                }
            );
        }
    }
}
