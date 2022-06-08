using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ModelBL;
using ModelGundam;

namespace ModelApi.Controllers
{
    [ApiController]
    [Route("api/[controller")]
    public class StoreController : ControllerBase
    {
        private IStoreBL _storeBL;
        public StoreController(IStoreBL m_storeBL)
        {
            _storeBL = m_storeBL;
        }
        [HttpGet("ViewStoreInventory")]
        public IActionResult ViewStoreInventory([FromQuery] int m_sID)
        {
            return Ok(_storeBL.ViewStoreInventory(m_sID));
        }
        
    }
}