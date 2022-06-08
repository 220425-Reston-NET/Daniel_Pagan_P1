using Microsoft.AspNetCore.Mvc;
using ModelBL;

namespace ModelApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private IStoreBL _storeBL;
        public StoreController(IStoreBL m_storeBL)
        {
            _storeBL = m_storeBL;
        }
        [HttpGet("ViewStoreInventory")]
        public IActionResult ViewStoreInventory([FromQuery] int p_sID)
        {
            return Ok(_storeBL.ViewStoreInventory(p_sID));
        }
    }
}