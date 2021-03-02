using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SesriCatiApi.Models;

namespace SesriCatiApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DimDeviceModelsController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public DimDeviceModelsController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/DimDeviceModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimDeviceModel>>> GetDimDeviceModel()
        {
            return await _context.DimDeviceModel.ToListAsync();
        }

        // GET: api/DimDeviceModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimDeviceModel>> GetDimDeviceModel(int id)
        {
            var dimDeviceModel = await _context.DimDeviceModel.FindAsync(id);

            if (dimDeviceModel == null)
            {
                return NotFound();
            }

            return dimDeviceModel;
        }

        // PUT: api/DimDeviceModels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDimDeviceModel(int id, DimDeviceModel dimDeviceModel)
        {
            if (id != dimDeviceModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(dimDeviceModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DimDeviceModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DimDeviceModels
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DimDeviceModel>> PostDimDeviceModel(DimDeviceModel dimDeviceModel)
        {
            _context.DimDeviceModel.Add(dimDeviceModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDimDeviceModel", new { id = dimDeviceModel.Id }, dimDeviceModel);
        }

        // DELETE: api/DimDeviceModels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DimDeviceModel>> DeleteDimDeviceModel(int id)
        {
            var dimDeviceModel = await _context.DimDeviceModel.FindAsync(id);
            if (dimDeviceModel == null)
            {
                return NotFound();
            }

            _context.DimDeviceModel.Remove(dimDeviceModel);
            await _context.SaveChangesAsync();

            return dimDeviceModel;
        }

        private bool DimDeviceModelExists(int id)
        {
            return _context.DimDeviceModel.Any(e => e.Id == id);
        }
    }
}
