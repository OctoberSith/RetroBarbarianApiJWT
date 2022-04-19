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
    public class ProductsController : ControllerBase
    {
        private readonly ProductsBL _prodBL;

        public ProductsController(ProductsBL prodBL)
        {
            _prodBL = prodBL;
        }

        [HttpGet("alpha")]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                Log.Information("Call for GetAllProducts is ok.");
                return Ok(await _prodBL.GetAll());
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Products Not Found.");
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpPost("beta")]
        public async Task<IActionResult> AddProducts(Products p_resource)
        {
            try
            {
                Log.Information("Products Added.");
                return Ok(await _prodBL.Add(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Products Not Added.");
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpPut("gamma")]
        public async Task<IActionResult> UpdateProducts(Products p_resource)
        {
            try
            {
                Log.Information("Products Updated.");
                return Ok( await _prodBL.Update(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Products Not Updated.");
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpDelete("delta")]
        public async Task<IActionResult> DeleteProducts(Products p_resource)
        {
            try
            {
                Log.Information("Products Deleted.");
                return Ok(await _prodBL.Delete(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Products Not Deleted.");
                return StatusCode(404, "Not Found");
            }
        }

    }
}
