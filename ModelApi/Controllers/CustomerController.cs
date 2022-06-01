using Microsoft.AspNetCore.Mvc;
using ModelBL;

namespace CustomerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private ICustomerBL _customerBL;
        private ICustomersModelsJoinBL _cmjb;

        public CustomerController(ICustomerBL customerBL, ICustomersModelsJoinBL customersModelsJoin)
        {
            _customerBL = customerBL;
            _cmjb = customersModelsJoin;
        }
        
    // [HttpGet("GetAllCustomer")]
    // public async Task<IActionResult> GetAllCustomer()
    // {
    //     try
    //     {
    //         // List<Customer> listOfCurrentCustomer = _CustomerBL.GetAllCustomerAsync();

    //         // return ok(listOFCurrentCustomer);
    //     }
    //     catch (System.Exception)
    //     {
            
    //         throw;
    //     }
    // }
    }
}
