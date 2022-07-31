using EFCoreAIGS.Data.Base;
using EFCoreAIGS.Data.Entities;

namespace EFCoreAIGS.Data.Service
{
    public interface IEmployeeService : IBaseService<Employee>
    {
        public String Display();
    }
}
