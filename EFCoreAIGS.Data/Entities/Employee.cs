#nullable enable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFCoreAIGS.Data.Entities.command;

namespace EFCoreAIGS.Data.Entities
{
    public class Employee : BaseEntity
    {
        [MaxLength(50)]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime Hired { get; set; }


        //Not add this field to Table
        [NotMapped]
        public decimal TotalSpendings { get; set; }

        //One-to-One
        public virtual CreditCard? CreditCard { get; set; }

        //One-to-Many
        public List<SpendingDetails>? SpendingDetails { get; set; }

    }
}
