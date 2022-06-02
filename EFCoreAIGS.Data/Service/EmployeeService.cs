using EFCoreAIGS.Data.Base;
using EFCoreAIGS.Data.Entities;

namespace EFCoreAIGS.Data.Service
{
    public class EmployeeService : BaseService<Employee>
    {
        public void disPlayName()
        {
            Console.WriteLine($"^^ {Get(1)!.LastName}");
        }

        public override List<Employee> GetAll()
        {
            Console.WriteLine("Hiiii this is override");
            return base.GetAll();
        }

        public void testCase()
        {
         listFilter(employee => employee.FirstName == "liza" || employee.LastName == "");
        }
    }
}
