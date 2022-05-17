using System.ComponentModel.DataAnnotations;
using EFCoreAIGS.Data.Entities.command;


namespace EFCoreAIGS.Data.Entities
{
    public class SpendingDetails : BaseEntity
    {
        // [Key]
        // public int SpendingDetailId { get; set; }
        public string SpentOn { get; set; }
        public decimal Amount { get; set; }
        
        
        public int  EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
