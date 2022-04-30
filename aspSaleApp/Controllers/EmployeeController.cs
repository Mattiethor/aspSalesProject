using aspSaleApp.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ntv_database.Models;

namespace aspSaleApp.Controllers
{

    [Route("api/employees")]
    [Controller]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepository _repository;

        public EmployeeController(IRepository repository)
        {
            _repository = repository;
        }



       [HttpGet]

        public List<Employee> GetAllemployees()
        {
            try
            {
                List<Employee> employees = _repository.GetAllEmployees();
                return employees;

            }
            catch (Exception)
            {

                return null;
            }

        }
        

       
    }
}
