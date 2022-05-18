using EFCoreAIGS.Data.Entities.command;

namespace EFCoreAIGS.Data.Entities;

public class Spend : BaseEntity
{
    public int IncomeSpendingDetailsId { get; set; }
    public virtual SpendingDetails IncomeSpendingDetails { get; set; }
    
    public int OutcomeSpendingDetailsId { get; set; }
    public virtual SpendingDetails OutcomeSpendingDetails { get; set; }
    
    public DateTime Date { get; set; }
}