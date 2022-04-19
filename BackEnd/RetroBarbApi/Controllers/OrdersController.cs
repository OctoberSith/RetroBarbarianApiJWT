using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetroModels;
using RetroBL;

namespace RetroBarbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrdersBL _ordBL;

        public OrdersController(OrdersBL ordBL)
        {
            _ordBL = ordBL;
        }

        [HttpGet("alpha")]
        public async Task<IActionResult> GetAllOrders()
        {
            try
            {
                Log.Information("Call for GetAllOrders is ok.");
                return Ok(await _ordBL.GetAll());
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Orders Not Found.");
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpPost("beta")]
        public async Task<IActionResult> AddInventory(Orders p_resource)
        {
            try
            {
                Log.Information("Orders Added.");
                return Ok(await _ordBL.Add(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Orders Not Added.");
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpPut("gamma")]
        public async Task<IActionResult> UpdateOrders(Orders p_resource)
        {
            try
            {
                Log.Information("Orders Updated.");
                return Ok( await _ordBL.Update(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Orders Not Updated.");
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpDelete("delta")]
        public async Task<IActionResult> DeleteOrders(Orders p_resource)
        {
            try
            {
                Log.Information("Orders Deleted.");
                return Ok(await _ordBL.Delete(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Orders Not Deleted.");
                return StatusCode(404, "Not Found");
            }
        }


    }
}
