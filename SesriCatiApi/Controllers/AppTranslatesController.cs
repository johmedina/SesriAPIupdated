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
    public class AppTranslatesController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public AppTranslatesController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/AppTranslates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppTranslate>>> GetAppTranslate()
        {
            return await _context.AppTranslate.ToListAsync();
        }

        // GET: api/AppTranslates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppTranslate>> GetAppTranslate(int id)
        {
            var appTranslate = await _context.AppTranslate.FindAsync(id);

            if (appTranslate == null)
            {
                return NotFound();
            }

            return appTranslate;
        }

        // PUT: api/AppTranslates/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppTranslate(int id, AppTranslate appTranslate)
        {
            if (id != appTranslate.Id)
            {
                return BadRequest();
            }

            _context.Entry(appTranslate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppTranslateExists(id))
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

        // POST: api/AppTranslates
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AppTranslate>> PostAppTranslate(AppTranslate appTranslate)
        {
            _context.AppTranslate.Add(appTranslate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppTranslate", new { id = appTranslate.Id }, appTranslate);
        }

        // DELETE: api/AppTranslates/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AppTranslate>> DeleteAppTranslate(int id)
        {
            var appTranslate = await _context.AppTranslate.FindAsync(id);
            if (appTranslate == null)
            {
                return NotFound();
            }

            _context.AppTranslate.Remove(appTranslate);
            await _context.SaveChangesAsync();

            return appTranslate;
        }

        private bool AppTranslateExists(int id)
        {
            return _context.AppTranslate.Any(e => e.Id == id);
        }
    }
}
