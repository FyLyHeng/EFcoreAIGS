#nullable enable
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFCoreAIGS.Data.Configuration.EntityConfig;
using EFCoreAIGS.Data.Entities.command;
using EFCoreAIGS.Data.Entities.Validation;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAIGS.Data.Entities
{
    [EntityTypeConfiguration(typeof(EmployeeConfig))]
    public class Employee : BaseEntity
    {
        [MaxLength(50)]
        public string? FirstName { get; set; }
        
        [StringLength(50)]
        [DefaultValue("default name")]
        public string? LastName { get; set; }
        public DateTime Hired { get; set; }


        //Not add this field to Table
        [NotMapped]
        [Range(0,1000)]
        public decimal TotalSpendings { get; set; }

        //One-to-One
        [EmployeeValidation] //Inject custom validation stand for if else in bus logic code.
        public virtual CreditCard? CreditCard { get; set; }

        //One-to-Many
        public List<SpendingDetails>? SpendingDetails { get; set; }

    }
}
