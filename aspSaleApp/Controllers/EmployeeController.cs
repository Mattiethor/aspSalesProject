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

        public ActionResult <List<Employee>> GetAllemployees()
        {
            try
            {
                List<Employee> employees = _repository.GetAllEmployees();
                return employees;

            }
            catch (Exception)
            {

                return StatusCode(500);
            }

        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Employee> GetEmployeeById(int id)
        {
            
            try
            {
                Employee employee = _repository.GetEmployeeById(id);
                if (employee == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(employee);
                }

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        

       
    }
}
