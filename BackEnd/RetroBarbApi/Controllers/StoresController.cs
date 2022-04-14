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
    public class StoresController : ControllerBase
    {
        private readonly StoresBL _prodBL;

        public StoresController(StoresBL prodBL)
        {
            _prodBL = prodBL;
        }

        [HttpGet("GetAllStores")]
        public async Task<IActionResult> GetAllStores()
        {
            try
            {
                return Ok(await _prodBL.GetAll());
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpPost("PostStores")]
        public async Task<IActionResult> AddStores(Stores p_resource)
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
        
        [HttpPut("PutStores")]
        public async Task<IActionResult> UpdateStores(Stores p_resource)
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
        
        [HttpDelete("DeleteStores")]
        public async Task<IActionResult> DeleteStores(Stores p_resource)
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
