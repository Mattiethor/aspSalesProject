using aspSaleApp.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ntv_database.Models;

namespace aspSaleApp.Controllers

{
    [Route("api/itemorders")]
    [Controller]
    
    public class ItemOrderController : ControllerBase
    {
        private readonly IRepository _repository;

        public ItemOrderController(IRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public ActionResult<List<ItemOrder>> GetAllItems()
        {
            try
            {
                List<ItemOrder> itemOrders = _repository.GetAllItemsOrder();
                return itemOrders;

            }
            catch (Exception)
            {

                return StatusCode(500);
            }

        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<ItemOrder> GetItemOrderById(int id)
        {

            try
            {
                ItemOrder itemOrder = _repository.GetItemOrderById(id);
                if (itemOrder == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(itemOrder);
                }

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }


    }
}
