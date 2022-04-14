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

        [HttpGet("GetAllCustomers")]
        public async Task<IActionResult> GetAllCustomers()
        {
            try
            {
                return Ok(await _custBL.GetAll());
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }


        [HttpPost("PostCustomers")]
        public async Task<IActionResult> AddCustomers(Customers p_resource)
        {
            try
            {
                return Ok(await _custBL.Add(p_resource));
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }
        

        [HttpPut("PutCustomers")]
        public async Task<IActionResult> UpdateCustomers(Customers p_resource)
        {
            try
            {
                return Ok(await _custBL.Update(p_resource));
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }
        

        [HttpDelete("DeleteCustomers")]
        public async Task<IActionResult> DeleteCustomers(Customers p_resource)
        {
            try
            {
                return Ok(await _custBL.Delete(p_resource));   
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }

    }
}
