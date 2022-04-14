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

        [HttpGet("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            try
            {
                return Ok(_prodBL.GetAll());
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpPost("PostProducts")]
        public async Task<IActionResult> AddProducts(Products p_resource)
        {
            try
            {
                return Ok(await _prodBL.Add(p_resource));
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpPut("PutProducts")]
        public async Task<IActionResult> UpdateProducts(Products p_resource)
        {
            try
            {
                return Ok( await _prodBL.Update(p_resource));
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpDelete("DeleteProducts")]
        public async Task<IActionResult> DeleteProducts(Products p_resource)
        {
            try
            {
                return Ok(await _prodBL.Delete(p_resource));
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }

    }
}
