using EFCoreAIGS.Data;
using EFCoreAIGS.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAIGS.UI
{
    public class ExecuteLogic
    {
        
        private static AIGSContext repo  = new AIGSContext();
        public ExecuteLogic() {}
            
        internal void Execute()
        {

            //Add 1 new Employee to DataBase
            addnewEmployee("liza", "Kok");

            //Add multi Employee to DataBase
            AddRangeEmployee();
            
            //write to console Log
            ReadAllEmployee();
            
            FilterAndOrderEmployee();
        }

        internal void ExecuteAsync()
        {
            //await CRUD_Add();
            //await CRUD_Save();
            
            CRUD_Get(41);

            //CRUD_List();
            CURD_Filter();
            // CURD_Filter_EF_Fun();
            // CRUD_Filter_LINQ();
            
            
            //CRUD_Update_Add_Child(41);
            //CRUD_Update_Add_Child(41);
            //CRUD_Update(41);

            CRUD_Delete();
        }
        
        
        private void AddRangeEmployee()
        {
          using var db = new AIGSContext();
            var empList = new List<Employee>();
            empList.Add(new Employee
            {
                FirstName = "Jonh",
                LastName = "Son",
                Hired = DateTime.Now
            });
            empList.Add(new Employee
            {
                FirstName = "Jonh",
                LastName = "Sey",
                Hired = DateTime.Now
            });
            
            // AddRange Perform only 1 statement for insert multi record (bulk processing)
            db.Employees.AddRange(empList);
            db.SaveChangesAsync();
        }
        private void addnewEmployee(string firstname, string lastname) 
        {
        
            var emp = new Employee
            {
                FirstName = firstname,
                LastName = lastname,
                Hired = DateTime.Now
            };
            using var db = new AIGSContext();
            db.Employees.Add(emp);
            db.SaveChanges();
        }
        private void ReadAllEmployee()
        {
            using var db = new AIGSContext();
            
            var employees = db.Employees.Where(emp=>
                emp.FirstName == ""
                ).ToList();
            
            foreach (var emp in employees)
            {
                Console.WriteLine($"employee name {emp.FirstName}  {emp.LastName}, Joined Date: {emp.Hired}");
            }
        }
        private void FilterAndOrderEmployee()
        {
            var db = new AIGSContext();
        
            var empList = db.Employees
                .Where(x => x.FirstName != "")
                .OrderByDescending(x => x.EmployeeId)
                .ToList();
        
        
            foreach (var it in empList)
            {
                Console.WriteLine($"employee name {it.FirstName}  {it.LastName}, Joined Date: {it.Hired}");
            }
        }

        //======== await with Async ========
        
        //============== GET OPERATION ============== 
        private void CRUD_Get(int id)
        {
            var emp = repo.Employees.Find(id);
            Console.WriteLine($"found {emp?.Hired}");
        }
        
        //============== Save OPERATION ==============       
        
        private async Task CRUD_Add()
        {
            Console.WriteLine("Before Save !");
            var employee = new Employee { FirstName = "New name pls", LastName = "no warry tom", Hired = DateTime.Now };
            await repo.Employees.AddAsync(employee);
            
            //Inject Service
            await AddSpandingDetailToEmployee(employee);
            await repo.SaveChangesAsync();
        }
        private async Task AddSpandingDetailToEmployee(Employee employee)
        {
            await Console.Error.WriteLineAsync("this is error log menural write....");
            var spanding = new List<SpendingDetails>
            {
                new SpendingDetails
                {
                    SpentOn = "Car",
                    Amount = 10000,
                    Employee = employee
                },
                new SpendingDetails
                {
                    SpentOn = "Bike",
                    Amount = 10000,
                    Employee = employee
                }
            };
            await repo.AddRangeAsync(spanding);
        }
        
        //save child and parent in one
        private async Task CRUD_Save()
        {
            Console.WriteLine("Before Save Child with parent !");
            var emps = new Employee
            {
                FirstName = "Tom",
                LastName = "kok",
                Hired = DateTime.Today.AddHours(1),
                SpendingDetails = new List<SpendingDetails>
                {
                    new SpendingDetails
                    {
                        SpentOn = "Coffee brand",
                        Amount = 100
                    },
                    new SpendingDetails
                    {
                        SpentOn = "Beer Brand",
                        Amount = 1000
                    }
                }
            };

            await repo.Employees.AddAsync(emps);
            await repo.SaveChangesAsync();
        }

        
        //============== Filter OPERATION ==============
        
        /* @NoTracking
         * recommand to use no Tracking with read only Operation (list, filter, get,...)
         *      pro: save memory tracking space
         */
        private async Task CRUD_List()
        {
            var emps  = repo.Employees.AsNoTracking().ToList();
            Console.WriteLine($"sample list : total :{emps.Count}");
            foreach (var emp in emps)
            {
                Console.WriteLine($"Emp {emp.FirstName}");
            }
        }
        
        private async Task CURD_Filter()
        {
            var name = "liza";
            var ids = new List<int>{41,42};
            var emps = await repo.Employees.AsNoTracking()
                .Where(q => q.FirstName.Contains("liza"))
                .Where(q=> ids.Contains(q.EmployeeId))
                .OrderByDescending(q=> q.Hired)
                .ToListAsync();
            
            Console.WriteLine($"Filter list total:: {emps.Count}");
            foreach (var emp in emps)
            {
                Console.WriteLine($"Emp {emp.FirstName} {emp.Hired}");
            }
        }
        
        private void CURD_Filter_EF_Fun()
        {
            var name = "liza";
            var ids = new List<int>{41,42};
            var emps = repo.Employees.AsNoTracking()
                .Where(q=> EF.Functions.ILike(q.FirstName,$"%{name}%")).ToList();
            
            Console.WriteLine($"Filter list total:: {emps.Count}");
            foreach (var emp in emps)
            {
                Console.WriteLine($"Emp {emp.FirstName} {emp.Hired}");
            }
        }
        
        private void CRUD_Filter_LINQ()
        {
            var emps = from it in repo.Employees select it;

            foreach (var emp in emps)
            {
                Console.WriteLine($"LinQ {emp.FirstName}");
            }
        }
        
        
        //============== Update OPERATION ==============
        private void CRUD_Update(int employeeId)
        {
            var emp = repo.Employees
                .Include(q => 
                    q.SpendingDetails.Where(d=> d.Amount>100))
                .Single(q => q.EmployeeId == employeeId);
            
            emp.FirstName = "child has been remove";
            emp.SpendingDetails.Remove(emp.SpendingDetails.First());
            
            //Update() to tell the DBContext that Data have been mordifi
            //In case the Primary key (id) null it will perform add new Record.
            //In case the Primary key (id) not exist in DB it will throw exp
            repo.Update(emp);
            repo.SaveChanges();
            Console.WriteLine($"ID {employeeId} found emp {emp}");
        }

        private void CRUD_Update_Add_Child(int id)
        {
            var emp = repo.Employees.Single(q => q.EmployeeId == id);
            emp.SpendingDetails.Add(new SpendingDetails { SpentOn = "Coffee", Amount = 1001 });
            repo.Update(emp);
            repo.SaveChanges();
        } 
        
        
        //============== Delete OPERATION ==============
        private async Task CRUD_Delete()
        {
            var emp = await repo.Employees.FindAsync(21);
            if (emp!=null)
            {
                repo.Remove(emp);
                await repo.SaveChangesAsync();
            }
        }
    }
}
