namespace EFCoreAIGS.Data.Entities.DTO;

public class EmployeeDetail
{
    public String FullName { set; get; }
    public string? CreditCard { set; get; }
    public Double Balance { get; set; }
    public int TotalSpendTrax { set; get; }
}