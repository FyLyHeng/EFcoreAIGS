using EFCoreAIGS.Data;
using EFCoreAIGS.Data.Entities;
using EFCoreAIGS.Data.Entities.DTO;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAIGS.UI
{
    public class ExecuteLogicDBRelationship
    {
        private static AIGSContext repo = new AIGSContext();

        internal void ExecuteLogic()
        {
            var employee = repo.Employees.First();
            // AddOneToOne();
            // InitManyToMany();
            // UpdateManyToMany();


            //selectOneProperty();
            selectWithDynamicMapping(41);
            selectWithDTO(42);

        }



        //==== Include (Join-Fetch) ======

        private void AddOneToOne()
        {
            var id = 41;
            var empWithCredit = repo.Employees.Include(q => q.CreditCard).SingleOrDefault(q => q.Id == id);

            Console.WriteLine($"Credit Card : {empWithCredit?.CreditCard?.CreditCardNumber}");

            if (empWithCredit is {CreditCard: null})
            {
                var creditCard = new CreditCard
                {
                    CreditCardNumber = "000 789 123 451", Balance = 1000, TotalIncomeAmount = 2000,
                    TotalOutcomeAmount = 1000, Employee = empWithCredit
                };
                empWithCredit.CreditCard = creditCard;
                repo.Update(empWithCredit);
                repo.SaveChanges();
            }
            Console.WriteLine($"Find emp : {id} => result : {empWithCredit?.Hired}");
        }

        private void InitManyToMany()
        {
            var id = 42;
            var empWithCredit = repo.Employees
                .Include(q => q.SpendingDetails)
                .Include(q => q.SpendingDetails)
                .SingleOrDefault(q => q.Id == id);


            var spend = new Spend
            {
                IncomeSpendingDetails = new SpendingDetails
                {
                    SpentOn = "Salary",
                    Amount = 500
                },
                OutcomeSpendingDetails = new SpendingDetails
                {
                    SpentOn = "Salary",
                    Amount = 500
                }
            };

            var spendingDetails = new SpendingDetails
            {
                SpentOn = "Income && Outcome",
                Amount = 0,
                IncomeSpend = new List<Spend> {spend},
                OutcomeSpend = new List<Spend> {spend}
            };

            if (empWithCredit != null)
            {
                empWithCredit.SpendingDetails = new List<SpendingDetails> {spendingDetails};
                repo.Update(empWithCredit);
                repo.SaveChanges();
            }



            foreach (var spendingDetail in empWithCredit?.SpendingDetails)
            {
                Console.WriteLine($"spend of 41 {spendingDetail.Id} : {spendingDetail.Amount} [ Income {spendingDetail.IncomeSpend.Count} :Outcome {spendingDetail.OutcomeSpend.Count}]");
            }
        }

        private void UpdateManyToMany()
        {
            var emp = getEmployeeWithSpend(42);
            foreach (var detail in emp.SpendingDetails)
            {
                detail.SpentOn = "InCome && OutCOme";

                foreach (var spend in detail.IncomeSpend)
                {
                    spend.IncomeSpendingDetails.SpentOn = "InCome Salary PayOff";
                }
                foreach (var spend in detail.OutcomeSpend)
                {
                    spend.IncomeSpendingDetails.SpentOn = "OutCome Daily PayOff";
                }
            }

            repo.Update(emp);
            repo.SaveChanges();

            printEmployeeWithSpendDetail(emp);
        }

        //==== Projection (DTO) ======

        private void selectOneProperty()
        {
            var emp = repo.Employees.Find(41)!.FirstName;
            Console.WriteLine($"EMP {emp}");

            var emp1 = repo.Employees.Where(q => q.Id == 41).Select(q => q.FirstName).SingleOrDefault();
            Console.WriteLine($"EMP1 {emp1}");

            var emp2 = repo.Employees.AsNoTracking().Where(q => q.Id == 41).Select(q => q.FirstName).SingleOrDefault();
            Console.WriteLine($"EMP2 {emp2}");

        }


        private void selectWithDynamicMapping(int id)
        {
            var emp = repo.Employees
                .Where(q => q.Id == id)
                .Select(q => new
                {
                    FullName = $"{q.FirstName}-{q.LastName}",
                    CreditCard = q.CreditCard!.CreditCardNumber,
                    Balacne = q.CreditCard.Balance,
                    TotalSpendTrax = q.SpendingDetails!.Count
                }).SingleOrDefault();

            Console.WriteLine($"Dynamic Mapping : {emp}");
        }

        private void selectWithDTO(int id)
        {
            var emp = repo.Employees
                .Where(q => q.Id == id)
                .Select(q => new EmployeeDetail
                {
                    FullName = $"{q.FirstName}-{q.LastName}",
                    CreditCard = q.CreditCard != null?q.CreditCard.CreditCardNumber:"invalid credit card number",
                    Balance = q.CreditCard != null?q.CreditCard.Balance:0,
                    TotalSpendTrax = q.SpendingDetails != null?q.SpendingDetails.Count:0
                }).SingleOrDefault();

            Console.WriteLine($"DTO Mapping : {emp.FullName}, {emp.CreditCard}, {emp.Balance}, {emp.TotalSpendTrax}");
        }




        //===== small fun ======

        private Employee? getEmployeeWithSpend(int id)
        {
            var empWithCredit = repo.Employees
                .Include(q => q.SpendingDetails)//.ThenInclude(q => q.OutcomeSpend)
                //.Include(q => q.SpendingDetails)//.ThenInclude(q => q.IncomeSpend)
                .FirstOrDefault(q => q.Id == id || q.FirstName !=null || !q.FirstName!.Equals(String.Empty));

            return empWithCredit;
        }

        private void printEmployeeWithSpendDetail(Employee? empWithCredit)
        {
            foreach (var spendingDetail in empWithCredit.SpendingDetails)
            {
                Console.WriteLine($"spend of 41 {spendingDetail.Id} : {spendingDetail.Amount} [ Income {spendingDetail.IncomeSpend.Count} :Outcome {spendingDetail.OutcomeSpend.Count}]");
            }
        }
        private void printEmployeeDetail(Employee? empWithCredit)
        {
            foreach (var spendingDetail in empWithCredit.SpendingDetails)
            {
                Console.WriteLine($"spend of 41 {spendingDetail.Id} : {spendingDetail.Amount} [ Income {spendingDetail.IncomeSpend.Count} :Outcome {spendingDetail.OutcomeSpend.Count}]");
            }
        }

    }
}
