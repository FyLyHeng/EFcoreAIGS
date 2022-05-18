using EFCoreAIGS.Data.Entities.command;

namespace EFCoreAIGS.Data.Entities;

public class CreditCard : BaseEntity
{
    public string? CreditCardNumber { get; set; }
    public Double Balance { get; set; }
    public Double TotalIncomeAmount { get; set; }
    public Double TotalOutcomeAmount { get; set; }
    
    public int EmployeeId { get; set; }
    public virtual Employee? Employee { get; set; }
}