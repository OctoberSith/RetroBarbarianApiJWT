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

        [HttpGet("GetAllOrders")]
        public async Task<IActionResult> GetAllOrders()
        {
            try
            {
                return Ok(await _ordBL.GetAll());
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpPost("PostOrders")]
        public async Task<IActionResult> AddInventory(Orders p_resource)
        {
            try
            {
                return Ok(await _ordBL.Add(p_resource));
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpPut("PutOrders")]
        public async Task<IActionResult> UpdateOrders(Orders p_resource)
        {
            try
            {
                return Ok( await _ordBL.Update(p_resource));
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpDelete("DeleteOrders")]
        public async Task<IActionResult> DeleteOrders(Orders p_resource)
        {
            try
            {
                return Ok(await _ordBL.Delete(p_resource));
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }


    }
}
