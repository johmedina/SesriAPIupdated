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
    public class DimIssuesController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public DimIssuesController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/DimIssues
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimIssue>>> GetDimIssue()
        {
            return await _context.DimIssue.ToListAsync();
        }

        // GET: api/DimIssues/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimIssue>> GetDimIssue(int id)
        {
            var dimIssue = await _context.DimIssue.FindAsync(id);

            if (dimIssue == null)
            {
                return NotFound();
            }

            return dimIssue;
        }

        // PUT: api/DimIssues/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDimIssue(int id, DimIssue dimIssue)
        {
            if (id != dimIssue.Id)
            {
                return BadRequest();
            }

            _context.Entry(dimIssue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DimIssueExists(id))
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

        // POST: api/DimIssues
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DimIssue>> PostDimIssue(DimIssue dimIssue)
        {
            _context.DimIssue.Add(dimIssue);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DimIssueExists(dimIssue.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDimIssue", new { id = dimIssue.Id }, dimIssue);
        }

        // DELETE: api/DimIssues/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DimIssue>> DeleteDimIssue(int id)
        {
            var dimIssue = await _context.DimIssue.FindAsync(id);
            if (dimIssue == null)
            {
                return NotFound();
            }

            _context.DimIssue.Remove(dimIssue);
            await _context.SaveChangesAsync();

            return dimIssue;
        }

        private bool DimIssueExists(int id)
        {
            return _context.DimIssue.Any(e => e.Id == id);
        }
    }
}
