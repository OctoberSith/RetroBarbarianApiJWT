using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetroModels;
using RetroBL;
using Microsoft.AspNetCore.Authorization;

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

        [HttpGet("alpha"), Authorize(Roles = "User")]
        public async Task<IActionResult> GetAllStores()
        {
            try
            {
                Log.Information("Call for GetAllStores is ok.");
                return Ok(await _prodBL.GetAll());
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Stores Not Found.");
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpPost("beta"), Authorize(Roles = "User")]
        public async Task<IActionResult> AddStores(Stores p_resource)
        {
            try
            {
                Log.Information("Stores Added.");
                return Ok(await _prodBL.Add(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Stores Not Added.");
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpPut("gamma"), Authorize(Roles = "User")]
        public async Task<IActionResult> UpdateStores(Stores p_resource)
        {
            try
            {
                Log.Information("Stores Updated.");
                return Ok( await _prodBL.Update(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Stores Not Updated.");
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpDelete("delta"), Authorize(Roles = "User")]
        public async Task<IActionResult> DeleteStores(Stores p_resource)
        {
            try
            {
                Log.Information("Stores Deleted.");
                return Ok(await _prodBL.Delete(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Stores Not Deleted.");
                return StatusCode(404, "Not Found");
            }
        }

    }
}
