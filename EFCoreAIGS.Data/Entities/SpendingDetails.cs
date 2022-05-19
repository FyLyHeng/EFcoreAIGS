using EFCoreAIGS.Data.Entities.command;


namespace EFCoreAIGS.Data.Entities
{
    public class SpendingDetails : BaseEntity
    {
        public string? SpentOn { get; set; }
        public decimal? Amount { get; set; }


        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        public virtual List<Spend>? IncomeSpend { get; set; }
        public virtual List<Spend>? OutcomeSpend { get; set; }

    }
}
