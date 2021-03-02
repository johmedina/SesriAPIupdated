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
    public class DimDevicesController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public DimDevicesController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/DimDevices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimDevice>>> GetDimDevice()
        {
            return await _context.DimDevice.ToListAsync();
        }

        // GET: api/DimDevices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimDevice>> GetDimDevice(int id)
        {
            var dimDevice = await _context.DimDevice.FindAsync(id);

            if (dimDevice == null)
            {
                return NotFound();
            }

            return dimDevice;
        }

        // PUT: api/DimDevices/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDimDevice(int id, DimDevice dimDevice)
        {
            if (id != dimDevice.Id)
            {
                return BadRequest();
            }

            _context.Entry(dimDevice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DimDeviceExists(id))
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

        // POST: api/DimDevices
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DimDevice>> PostDimDevice(DimDevice dimDevice)
        {
            _context.DimDevice.Add(dimDevice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDimDevice", new { id = dimDevice.Id }, dimDevice);
        }

        // DELETE: api/DimDevices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DimDevice>> DeleteDimDevice(int id)
        {
            var dimDevice = await _context.DimDevice.FindAsync(id);
            if (dimDevice == null)
            {
                return NotFound();
            }

            _context.DimDevice.Remove(dimDevice);
            await _context.SaveChangesAsync();

            return dimDevice;
        }

        private bool DimDeviceExists(int id)
        {
            return _context.DimDevice.Any(e => e.Id == id);
        }
    }
}
