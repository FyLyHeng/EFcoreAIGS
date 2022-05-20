### To Config Domain we can do 2 way:
    1- In Domain class : [Constant]
        Ex: 
            [MaxLength(50)]
            public string? FirstName { get; set; }
    
    
    2- In EntitiesConfig Class: By Override IEntityTypeConfiguration
        Ex:
            public class EmployeeConfig : IEntityTypeConfiguration<Employee>
                {
                    public void Configure(EntityTypeBuilder<Employee> builder)
                    {
                        builder.Property(q => q.FirstName).HasMaxLength(50);
                    }
                }