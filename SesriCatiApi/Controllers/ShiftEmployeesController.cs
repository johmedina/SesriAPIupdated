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
    public class ShiftEmployeesController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public ShiftEmployeesController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/ShiftEmployees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShiftEmployees>>> GetShiftEmployees()
        {
            return await _context.ShiftEmployees.ToListAsync();
        }

        // GET: api/ShiftEmployees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShiftEmployees>> GetShiftEmployees(int id)
        {
            var shiftEmployees = await _context.ShiftEmployees.FindAsync(id);

            if (shiftEmployees == null)
            {
                return NotFound();
            }

            return shiftEmployees;
        }

        // PUT: api/ShiftEmployees/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShiftEmployees(int id, ShiftEmployees shiftEmployees)
        {
            if (id != shiftEmployees.Id)
            {
                return BadRequest();
            }

            _context.Entry(shiftEmployees).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShiftEmployeesExists(id))
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

        // POST: api/ShiftEmployees
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ShiftEmployees>> PostShiftEmployees(ShiftEmployees shiftEmployees)
        {
            _context.ShiftEmployees.Add(shiftEmployees);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShiftEmployees", new { id = shiftEmployees.Id }, shiftEmployees);
        }

        // DELETE: api/ShiftEmployees/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ShiftEmployees>> DeleteShiftEmployees(int id)
        {
            var shiftEmployees = await _context.ShiftEmployees.FindAsync(id);
            if (shiftEmployees == null)
            {
                return NotFound();
            }

            _context.ShiftEmployees.Remove(shiftEmployees);
            await _context.SaveChangesAsync();

            return shiftEmployees;
        }

        private bool ShiftEmployeesExists(int id)
        {
            return _context.ShiftEmployees.Any(e => e.Id == id);
        }
    }
}
