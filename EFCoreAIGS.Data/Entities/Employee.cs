using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFCoreAIGS.Data.Entities.command;

namespace EFCoreAIGS.Data.Entities
{
    public class Employee : BaseEntity
    {
   
        public Employee()
        {
            SpendingDetails = new List<SpendingDetails>();
        }
        // [Key]
        // public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Hired { get; set; }
       
        [NotMapped]
        public decimal TotalSpendings { get; set; }

        public List<SpendingDetails> SpendingDetails { get; set; }

    }
}
