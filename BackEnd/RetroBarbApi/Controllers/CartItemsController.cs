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
    public class CartItemsController : ControllerBase
    {
        private readonly CartItemsBL _cartBL;

        public CartItemsController(CartItemsBL cartBL)
        {
            _cartBL = cartBL;
        }

        [HttpGet("alpha")]
        public async Task<IActionResult> GetAllCartItems()
        {
            try
            {
                Log.Information("Call for GetAllCartItems is ok.");
                return Ok(await _cartBL.GetAll());
            }
            catch (BadHttpRequestException)
            {
                Log.Information("CarItems Not Found.");
                return StatusCode(404, "Not Found");
            }
        }

        [HttpPost("beta")]
        public async Task<IActionResult> AddCartItems(CartItems p_resource)
        {
            try
            {
                Log.Information("CartItems Added.");
                return Ok(await _cartBL.Add(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("CartItems Not Added.");
                return StatusCode(404, "Not Found");
            }
        }
        

        [HttpPut("gamma")]
        public async Task<IActionResult> UpdateCartItems(CartItems p_resource)
        {
            try
            {
                Log.Information("CartItems Updated.");
                return Ok( await _cartBL.Update(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("CartItems Not Updated.");
                return StatusCode(404, "Not Found");
            }
        }
        

        [HttpDelete("delta")]
        public async Task<IActionResult> DeleteCartItems(CartItems p_resource)
        {
            try
            {
                Log.Information("CartItems Deleted.");
                return Ok(await _cartBL.Delete(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("CartItems Not Deleted.");
                return StatusCode(404, "Not Found");
            }
        }
        

    }
}
