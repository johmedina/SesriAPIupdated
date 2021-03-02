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
    public class OptionSetsController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public OptionSetsController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/OptionSets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OptionSet>>> GetOptionSet()
        {
            return await _context.OptionSet.ToListAsync();
        }

        // GET: api/OptionSets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OptionSet>> GetOptionSet(int id)
        {
            var optionSet = await _context.OptionSet.FindAsync(id);

            if (optionSet == null)
            {
                return NotFound();
            }

            return optionSet;
        }

        // PUT: api/OptionSets/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOptionSet(int id, OptionSet optionSet)
        {
            if (id != optionSet.Id)
            {
                return BadRequest();
            }

            _context.Entry(optionSet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OptionSetExists(id))
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

        // POST: api/OptionSets
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<OptionSet>> PostOptionSet(OptionSet optionSet)
        {
            _context.OptionSet.Add(optionSet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOptionSet", new { id = optionSet.Id }, optionSet);
        }

        // DELETE: api/OptionSets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OptionSet>> DeleteOptionSet(int id)
        {
            var optionSet = await _context.OptionSet.FindAsync(id);
            if (optionSet == null)
            {
                return NotFound();
            }

            _context.OptionSet.Remove(optionSet);
            await _context.SaveChangesAsync();

            return optionSet;
        }

        private bool OptionSetExists(int id)
        {
            return _context.OptionSet.Any(e => e.Id == id);
        }
    }
}
