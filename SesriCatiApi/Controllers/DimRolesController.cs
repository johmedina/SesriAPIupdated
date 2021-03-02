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
    public class DimRolesController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public DimRolesController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/DimRoles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimRole>>> GetDimRole()
        {
            return await _context.DimRole.ToListAsync();
        }

        // GET: api/DimRoles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimRole>> GetDimRole(int id)
        {
            var dimRole = await _context.DimRole.FindAsync(id);

            if (dimRole == null)
            {
                return NotFound();
            }

            return dimRole;
        }

        // PUT: api/DimRoles/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDimRole(int id, DimRole dimRole)
        {
            if (id != dimRole.Id)
            {
                return BadRequest();
            }

            _context.Entry(dimRole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DimRoleExists(id))
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

        // POST: api/DimRoles
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DimRole>> PostDimRole(DimRole dimRole)
        {
            _context.DimRole.Add(dimRole);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DimRoleExists(dimRole.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDimRole", new { id = dimRole.Id }, dimRole);
        }

        // DELETE: api/DimRoles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DimRole>> DeleteDimRole(int id)
        {
            var dimRole = await _context.DimRole.FindAsync(id);
            if (dimRole == null)
            {
                return NotFound();
            }

            _context.DimRole.Remove(dimRole);
            await _context.SaveChangesAsync();

            return dimRole;
        }

        private bool DimRoleExists(int id)
        {
            return _context.DimRole.Any(e => e.Id == id);
        }
    }
}
