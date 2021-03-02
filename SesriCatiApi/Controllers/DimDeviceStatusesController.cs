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
    public class DimDeviceStatusesController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public DimDeviceStatusesController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/DimDeviceStatuses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimDeviceStatus>>> GetDimDeviceStatus()
        {
            return await _context.DimDeviceStatus.ToListAsync();
        }

        // GET: api/DimDeviceStatuses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimDeviceStatus>> GetDimDeviceStatus(int id)
        {
            var dimDeviceStatus = await _context.DimDeviceStatus.FindAsync(id);

            if (dimDeviceStatus == null)
            {
                return NotFound();
            }

            return dimDeviceStatus;
        }

        // PUT: api/DimDeviceStatuses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDimDeviceStatus(int id, DimDeviceStatus dimDeviceStatus)
        {
            if (id != dimDeviceStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(dimDeviceStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DimDeviceStatusExists(id))
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

        // POST: api/DimDeviceStatuses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DimDeviceStatus>> PostDimDeviceStatus(DimDeviceStatus dimDeviceStatus)
        {
            _context.DimDeviceStatus.Add(dimDeviceStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDimDeviceStatus", new { id = dimDeviceStatus.Id }, dimDeviceStatus);
        }

        // DELETE: api/DimDeviceStatuses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DimDeviceStatus>> DeleteDimDeviceStatus(int id)
        {
            var dimDeviceStatus = await _context.DimDeviceStatus.FindAsync(id);
            if (dimDeviceStatus == null)
            {
                return NotFound();
            }

            _context.DimDeviceStatus.Remove(dimDeviceStatus);
            await _context.SaveChangesAsync();

            return dimDeviceStatus;
        }

        private bool DimDeviceStatusExists(int id)
        {
            return _context.DimDeviceStatus.Any(e => e.Id == id);
        }
    }
}
