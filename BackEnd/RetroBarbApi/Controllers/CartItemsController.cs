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

        [HttpGet("GetAllCartItems")]
        public async Task<IActionResult> GetAllCartItems()
        {
            try
            {
                return Ok(await _cartBL.GetAll());
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }

        
        [HttpPost("PostCartItems")]
        public async Task<IActionResult> AddCartItems(CartItems p_resource)
        {
            try
            {
                return Ok(await _cartBL.Add(p_resource));
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }
        

        [HttpPut("PutCartItems")]
        public async Task<IActionResult> UpdateCartItems(CartItems p_resource)
        {
            try
            {
                return Ok( await _cartBL.Update(p_resource));
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }
        

        [HttpDelete("DeleteCartItems")]
        public async Task<IActionResult> DeleteCartItems(CartItems p_resource)
        {
            try
            {
                return Ok(await _cartBL.Delete(p_resource));
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }
        

    }
}
