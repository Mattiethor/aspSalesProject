using aspSaleApp.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ntv_database.Models;

namespace aspSaleApp.Controllers
{

    [Route("api/sales")]
    [Controller]
    public class SaleController : ControllerBase
    {

        private readonly IRepository _repository;

        public SaleController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Sale>> GetAllSales()
        {
            try
            {
                List<Sale> sale = _repository.GetAllSales();
                return sale;

            }
            catch (Exception)
            {

                return StatusCode(500);
            }

        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Sale> GetSaleById(int id)
        {

            try
            {
                Sale sale = _repository.GetSaleById(id);
                if (sale == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(sale);
                }

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

    }
}
