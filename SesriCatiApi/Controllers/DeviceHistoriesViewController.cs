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
    public class DeviceHistoriesViewController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public DeviceHistoriesViewController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/DeviceHistoriesView
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeviceHistoryView>>> GetDeviceHistoryView()
        {
            return await _context.DeviceHistoryView.ToListAsync();
        }

        // GET: api/DeviceHistoriesView/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeviceHistoryView>> GetDeviceHistoryView(int id)
        {
            var deviceHistoryView = await _context.DeviceHistoryView.FindAsync(id);

            if (deviceHistoryView == null)
            {
                return NotFound();
            }

            return deviceHistoryView;
        }

        // PUT: api/DeviceHistoriesView/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeviceHistoryView(int id, DeviceHistoryView deviceHistoryView)
        {
            if (id != deviceHistoryView.Id)
            {
                return BadRequest();
            }

            _context.Entry(deviceHistoryView).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeviceHistoryViewExists(id))
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

        // POST: api/DeviceHistoriesView
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DeviceHistoryView>> PostDeviceHistoryView(DeviceHistoryView deviceHistoryView)
        {
            _context.DeviceHistoryView.Add(deviceHistoryView);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeviceHistoryView", new { id = deviceHistoryView.Id }, deviceHistoryView);
        }

        // DELETE: api/DeviceHistoriesView/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeviceHistoryView>> DeleteDeviceHistoryView(int id)
        {
            var deviceHistoryView = await _context.DeviceHistoryView.FindAsync(id);
            if (deviceHistoryView == null)
            {
                return NotFound();
            }

            _context.DeviceHistoryView.Remove(deviceHistoryView);
            await _context.SaveChangesAsync();

            return deviceHistoryView;
        }

        private bool DeviceHistoryViewExists(int id)
        {
            return _context.DeviceHistoryView.Any(e => e.Id == id);
        }
    }
}
