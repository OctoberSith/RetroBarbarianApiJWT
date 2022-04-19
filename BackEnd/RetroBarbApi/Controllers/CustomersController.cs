using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetroModels;
using RetroBL;
using Microsoft.Extensions.Caching.Memory;

namespace RetroBarbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMemoryCache _memorycache;
        private readonly CustomersBL _custBL;
        public CustomersController(CustomersBL custBL, IMemoryCache memoryCache)
        {
            _custBL = custBL;
            _memorycache = memoryCache;
        }

        [HttpGet("alpha")]
        public async Task<IActionResult> GetAllCustomers()
        {
            try
            {
                Log.Information("Call for GetAllCustomers is ok.");
                return Ok(await _custBL.GetAll());
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Customers Not Found.");
                return StatusCode(404, "Not Found");
            }
        }


        [HttpPost("beta")]
        public async Task<IActionResult> AddCustomers(Customers p_resource)
        {
            try
            {
                Log.Information("Customers Added.");
                return Ok(await _custBL.Add(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Customers Not Added.");
                return StatusCode(404, "Not Found");
            }
        }
        

        [HttpPut("gamma")]
        public async Task<IActionResult> UpdateCustomers(Customers p_resource)
        {
            try
            {
                Log.Information("Customers Updated.");
                return Ok(await _custBL.Update(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Customers Not Updated.");
                return StatusCode(404, "Not Found");
            }
        }
        

        [HttpDelete("delta")]
        public async Task<IActionResult> DeleteCustomers(Customers p_resource)
        {
            try
            {   
                Log.Information("Customers Deleted.");
                return Ok(await _custBL.Delete(p_resource));   
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Customers Not Deleted.");
                return StatusCode(404, "Not Found");
            }
        }

    }
}
