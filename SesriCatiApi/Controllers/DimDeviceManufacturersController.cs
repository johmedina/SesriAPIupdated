using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SesriCatiApi.Models;

namespace SesriCatiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DimDeviceManufacturersController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public DimDeviceManufacturersController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/DimDeviceManufacturers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimDeviceManufacturer>>> GetDimDeviceManufacturer()
        {
            return await _context.DimDeviceManufacturer.ToListAsync();
        }

        // GET: api/DimDeviceManufacturers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimDeviceManufacturer>> GetDimDeviceManufacturer(int id)
        {
            var dimDeviceManufacturer = await _context.DimDeviceManufacturer.FindAsync(id);

            if (dimDeviceManufacturer == null)
            {
                return NotFound();
            }

            return dimDeviceManufacturer;
        }

        // PUT: api/DimDeviceManufacturers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDimDeviceManufacturer(int id, DimDeviceManufacturer dimDeviceManufacturer)
        {
            if (id != dimDeviceManufacturer.Id)
            {
                return BadRequest();
            }

            _context.Entry(dimDeviceManufacturer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DimDeviceManufacturerExists(id))
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

        // POST: api/DimDeviceManufacturers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DimDeviceManufacturer>> PostDimDeviceManufacturer(DimDeviceManufacturer dimDeviceManufacturer)
        {
            _context.DimDeviceManufacturer.Add(dimDeviceManufacturer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDimDeviceManufacturer", new { id = dimDeviceManufacturer.Id }, dimDeviceManufacturer);
        }

        // DELETE: api/DimDeviceManufacturers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DimDeviceManufacturer>> DeleteDimDeviceManufacturer(int id)
        {
            var dimDeviceManufacturer = await _context.DimDeviceManufacturer.FindAsync(id);
            if (dimDeviceManufacturer == null)
            {
                return NotFound();
            }

            _context.DimDeviceManufacturer.Remove(dimDeviceManufacturer);
            await _context.SaveChangesAsync();

            return dimDeviceManufacturer;
        }

        private bool DimDeviceManufacturerExists(int id)
        {
            return _context.DimDeviceManufacturer.Any(e => e.Id == id);
        }
    }
}
