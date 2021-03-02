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
    public class DeviceHistoriesController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public DeviceHistoriesController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/DeviceHistories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeviceHistory>>> GetDeviceHistory()
        {
            return await _context.DeviceHistory.ToListAsync();
        }

        // GET: api/DeviceHistories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeviceHistory>> GetDeviceHistory(int id)
        {
            var deviceHistory = await _context.DeviceHistory.FindAsync(id);

            if (deviceHistory == null)
            {
                return NotFound();
            }

            return deviceHistory;
        }

        // PUT: api/DeviceHistories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeviceHistory(int id, DeviceHistory deviceHistory)
        {
            if (id != deviceHistory.Id)
            {
                return BadRequest();
            }

            _context.Entry(deviceHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeviceHistoryExists(id))
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

        // POST: api/DeviceHistories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DeviceHistory>> PostDeviceHistory(DeviceHistory deviceHistory)
        {
            _context.DeviceHistory.Add(deviceHistory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeviceHistory", new { id = deviceHistory.Id }, deviceHistory);
        }

        // DELETE: api/DeviceHistories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeviceHistory>> DeleteDeviceHistory(int id)
        {
            var deviceHistory = await _context.DeviceHistory.FindAsync(id);
            if (deviceHistory == null)
            {
                return NotFound();
            }

            _context.DeviceHistory.Remove(deviceHistory);
            await _context.SaveChangesAsync();

            return deviceHistory;
        }

        private bool DeviceHistoryExists(int id)
        {
            return _context.DeviceHistory.Any(e => e.Id == id);
        }
    }
}
