using Microsoft.AspNetCore.Mvc;
using CustomerRegister_BackEnd.Models;
using CustomerRegister_BackEnd.Services;
using CustomerRegister_BackEnd.Services.IService;
using CustomerRegister_BackEnd.Services.Service;
using System.Globalization;


[ApiController]
public class CustomerController : ControllerBase
{
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
              _customerService = customerService;
        }

    [HttpGet]
    [Route("GetCustomers")]
    public async Task<ActionResult> GetCustomers()
    {
        var res = await _customerService.GetCustomers();
        return Ok(res);
    }

    [HttpPost]
    [Route("CreateCustomer")]
    public async Task<IActionResult> CreateCustomer([FromForm] Customer customer)
    {
        
        var res = await _customerService.CreateCustomer(customer);
        return Ok(res);
    }

    [HttpGet]
    [Route("GetCustomerByID")]
    public async Task<ActionResult<Customer>> GetCustomerByID(int id)

    {
        var res = await _customerService.GetCustomerByID(id);
        return res;
    }


    [HttpDelete]
    [Route("DeleteCustomerByID")]
    public async Task<ActionResult> DeleteCustomerByID(int id)
    {
        var res = await _customerService.DeleteCustomerByID(id);

        if (res == null)
        {
            return NotFound();
        }
        return Ok(id);
    }

}
