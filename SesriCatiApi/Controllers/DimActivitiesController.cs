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
    public class DimActivitiesController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public DimActivitiesController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/DimActivities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimActivity>>> GetDimActivity()
        {
            return await _context.DimActivity.ToListAsync();
        }

        // GET: api/DimActivities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimActivity>> GetDimActivity(string id)
        {
            var dimActivity = await _context.DimActivity.FindAsync(id);

            if (dimActivity == null)
            {
                return NotFound();
            }

            return dimActivity;
        }

        // PUT: api/DimActivities/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDimActivity(string id, DimActivity dimActivity)
        {
            if (id != dimActivity.ActivityCode)
            {
                return BadRequest();
            }

            _context.Entry(dimActivity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DimActivityExists(id))
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

        // POST: api/DimActivities
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DimActivity>> PostDimActivity(DimActivity dimActivity)
        {
            _context.DimActivity.Add(dimActivity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DimActivityExists(dimActivity.ActivityCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDimActivity", new { id = dimActivity.ActivityCode }, dimActivity);
        }

        // DELETE: api/DimActivities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DimActivity>> DeleteDimActivity(string id)
        {
            var dimActivity = await _context.DimActivity.FindAsync(id);
            if (dimActivity == null)
            {
                return NotFound();
            }

            _context.DimActivity.Remove(dimActivity);
            await _context.SaveChangesAsync();

            return dimActivity;
        }

        private bool DimActivityExists(string id)
        {
            return _context.DimActivity.Any(e => e.ActivityCode == id);
        }
    }
}
