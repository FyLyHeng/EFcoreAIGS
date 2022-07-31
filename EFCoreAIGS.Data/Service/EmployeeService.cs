using EFCoreAIGS.Data.Base;
using EFCoreAIGS.Data.Entities;

namespace EFCoreAIGS.Data.Service
{
    public class EmployeeService : IEmployeeService
    {


        public List<Employee> GetAll()
        {
            Console.WriteLine("Hiiii this is override");
            return new List<Employee>
            {
                new Employee{Id = 1, FirstName = "liza"},
                new Employee{Id = 2, FirstName = "kok"}
            };
        }
        
        public string Display()
        {
            Console.WriteLine("This is apply DI");
            return "This is apply DI";
        }
        
    }
}
