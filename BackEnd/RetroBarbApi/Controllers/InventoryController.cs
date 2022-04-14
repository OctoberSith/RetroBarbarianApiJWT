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

        [HttpGet("GetAllInventory")]
        public async Task<IActionResult> GetAllInventory()
        {
            try
            {
                return Ok(await _invBL.GetAll());
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpPost("PostInventory")]
        public async Task<IActionResult> AddInventory(Inventory p_resource)
        {
            try
            {
                return Ok(await _invBL.Add(p_resource));
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpPut("PutInventory")]
        public async Task<IActionResult> UpdateInventory(Inventory p_resource)
        {
            try
            {
                return Ok( await _invBL.Update(p_resource));
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }
        
        [HttpDelete("DeleteInventory")]
        public async Task<IActionResult> DeleteInventory(Inventory p_resource)
        {
            try
            {
                return Ok(await _invBL.Delete(p_resource));
            }
            catch (BadHttpRequestException)
            {
                return StatusCode(404, "Not Found");
            }
        }

    }
}
