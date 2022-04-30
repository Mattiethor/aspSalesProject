using aspSaleApp.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ntv_database.Models;

namespace aspSaleApp.Controllers
{

    [Route("api/customers")]
    [Controller]
    public class CustomerController : ControllerBase
    {
        private readonly IRepository _repository;

        public CustomerController(IRepository repository)
        {
            _repository = repository;
        }

        public ActionResult<List<Customer>> GetAllCustomer()
        {
            try
            {
                List<Customer> customers = _repository.GetAllCustomer();
                return customers;

            }
            catch (Exception)
            {

                return StatusCode(500);
            }


        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Customer> GetCustomerById(int id)
        {

            try
            {
                Customer customer = _repository.GetCustomerById(id);
                if (customer == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(customer);
                }

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }


    }
}
