using EFCoreAIGS.Data.Entities;
using EFCoreAIGS.Data.Service;

namespace EFCoreAIGS.Data.Application
{
    public class EmployeeApplication
    {
        private IEmployeeService _service;
        public EmployeeApplication(IEmployeeService service)
        {
            _service = service;
        }


        public String getAllEmployee()
        {
            return _service.Display();
        }
    }
}
