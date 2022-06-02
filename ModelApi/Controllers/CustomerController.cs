using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ModelBL;
using ModelGundam;

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

        [HttpGet("GetAllCustomer")]
        public IActionResult GetAllCustomer()
        {
            try
            {
                List<Customer> listOfCurrentCustomer = _customerBL.GetAllCustomer();

                return Ok(listOfCurrentCustomer);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer([FromBody] Customer c_customer)
        {
            try
            {
                _customerBL.AddCustomer(c_customer);
                return Created("Customer was added", c_customer);
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }

        [HttpGet("SearchCustomerByName")]
        public IActionResult SearchCustomer([FromQuery] string CustomerName)
        {
            try
            {
                return Ok(_customerBL.SearchCustomerByName(CustomerName));
            }
            catch (SqlException)
            {
                
                return Conflict();
            }
        }
    }
}
