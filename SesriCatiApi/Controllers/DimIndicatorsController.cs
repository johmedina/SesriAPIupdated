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
    public class DimIndicatorsController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public DimIndicatorsController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/DimIndicators
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimIndicator>>> GetDimIndicator()
        {
            return await _context.DimIndicator.ToListAsync();
        }

        // GET: api/DimIndicators/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimIndicator>> GetDimIndicator(int id)
        {
            var dimIndicator = await _context.DimIndicator.FindAsync(id);

            if (dimIndicator == null)
            {
                return NotFound();
            }

            return dimIndicator;
        }

        // PUT: api/DimIndicators/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDimIndicator(int id, DimIndicator dimIndicator)
        {
            if (id != dimIndicator.Id)
            {
                return BadRequest();
            }

            _context.Entry(dimIndicator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DimIndicatorExists(id))
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

        // POST: api/DimIndicators
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DimIndicator>> PostDimIndicator(DimIndicator dimIndicator)
        {
            _context.DimIndicator.Add(dimIndicator);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DimIndicatorExists(dimIndicator.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDimIndicator", new { id = dimIndicator.Id }, dimIndicator);
        }

        // DELETE: api/DimIndicators/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DimIndicator>> DeleteDimIndicator(int id)
        {
            var dimIndicator = await _context.DimIndicator.FindAsync(id);
            if (dimIndicator == null)
            {
                return NotFound();
            }

            _context.DimIndicator.Remove(dimIndicator);
            await _context.SaveChangesAsync();

            return dimIndicator;
        }

        private bool DimIndicatorExists(int id)
        {
            return _context.DimIndicator.Any(e => e.Id == id);
        }
    }
}
