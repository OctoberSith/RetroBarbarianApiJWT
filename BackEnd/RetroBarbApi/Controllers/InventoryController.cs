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
    public class InventoryController : ControllerBase
    {
        private readonly InventoryBL _invBL;

        public InventoryController(InventoryBL invBL)
        {
            _invBL = invBL;
        }

        [HttpGet("alpha")]
        public async Task<IActionResult> GetAllInventory()
        {
            
            try
            {   Log.Information("Call for GetAllInventory is ok.");
                return Ok(await _invBL.GetAll());
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Inventory Not Found.");
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpPost("beta")]
        public async Task<IActionResult> AddInventory(Inventory p_resource)
        {
            try
            {   
                Log.Information("Inventory Added.");
                return Ok(await _invBL.Add(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Inventory Not Added.");
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpPut("gamma")]
        public async Task<IActionResult> UpdateInventory(Inventory p_resource)
        {
            try
            {
                Log.Information("Inventory Updated.");
                return Ok( await _invBL.Update(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Inventory Not Updated.");
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpDelete("delta")]
        public async Task<IActionResult> DeleteInventory(Inventory p_resource)
        {
            try
            {
                Log.Information("Inventory Deleted.");
                return Ok(await _invBL.Delete(p_resource));
            }
            catch (BadHttpRequestException)
            {
                Log.Information("Inventory Not Deleted.");
                return StatusCode(404, "Not Found");
            }
        }

    }
}
