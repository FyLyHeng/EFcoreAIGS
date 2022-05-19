using EFCoreAIGS.Data.Entities.command;

namespace EFCoreAIGS.Data.Entities
{
    public class CreditCard : BaseEntity
    {
        public string? CreditCardNumber { get; set; }
        public double Balance { get; set; }
        public double TotalIncomeAmount { get; set; }
        public double TotalOutcomeAmount { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
