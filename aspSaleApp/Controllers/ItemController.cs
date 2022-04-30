


using aspSaleApp.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ntv_database.Models;

namespace aspSaleApp.Controllers
{
    [Route("api/items")]
    [Controller]
    public class ItemController: ControllerBase
    {
        private readonly IRepository _repository;

        public ItemController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]

        public ActionResult<List<Item>> GetAllItems()
        {
            try
            {
                List<Item> items = _repository.GetAllItems();
                return items;

            }
            catch (Exception)
            {

                return StatusCode(500);
            }

        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Item> GetItemById(int id)
        {

            try
            {
                Item item = _repository.GetItemById(id);
                if (item == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(item);
                }

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

    }
}
