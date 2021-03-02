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
    public class IndicatorsController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public IndicatorsController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/Indicators
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Indicators>>> GetIndicators()
        {
            return await _context.Indicators.ToListAsync();
        }

        // GET: api/Indicators/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Indicators>> GetIndicators(int id)
        {
            var indicators = await _context.Indicators.FindAsync(id);

            if (indicators == null)
            {
                return NotFound();
            }

            return indicators;
        }

        // PUT: api/Indicators/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIndicators(int id, Indicators indicators)
        {
            if (id != indicators.Id)
            {
                return BadRequest();
            }

            _context.Entry(indicators).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IndicatorsExists(id))
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

        // POST: api/Indicators
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Indicators>> PostIndicators(Indicators indicators)
        {
            _context.Indicators.Add(indicators);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIndicators", new { id = indicators.Id }, indicators);
        }

        // DELETE: api/Indicators/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Indicators>> DeleteIndicators(int id)
        {
            var indicators = await _context.Indicators.FindAsync(id);
            if (indicators == null)
            {
                return NotFound();
            }

            _context.Indicators.Remove(indicators);
            await _context.SaveChangesAsync();

            return indicators;
        }

        private bool IndicatorsExists(int id)
        {
            return _context.Indicators.Any(e => e.Id == id);
        }
    }
}
