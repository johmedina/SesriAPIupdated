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
    public class AllCaseDatasController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public AllCaseDatasController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/AllCaseDatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AllCaseData>>> GetAllCaseData()
        {
            return await _context.AllCaseData.ToListAsync();
        }

        // GET: api/AllCaseDatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AllCaseData>> GetAllCaseData(int id)
        {
            var allCaseData = await _context.AllCaseData.FindAsync(id);

            if (allCaseData == null)
            {
                return NotFound();
            }

            return allCaseData;
        }

        // PUT: api/AllCaseDatas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAllCaseData(int id, AllCaseData allCaseData)
        {
            if (id != allCaseData.ProjectId)
            {
                return BadRequest();
            }

            _context.Entry(allCaseData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AllCaseDataExists(id))
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

        // POST: api/AllCaseDatas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AllCaseData>> PostAllCaseData(AllCaseData allCaseData)
        {
            _context.AllCaseData.Add(allCaseData);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AllCaseDataExists(allCaseData.ProjectId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAllCaseData", new { id = allCaseData.ProjectId }, allCaseData);
        }

        // DELETE: api/AllCaseDatas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AllCaseData>> DeleteAllCaseData(int id)
        {
            var allCaseData = await _context.AllCaseData.FindAsync(id);
            if (allCaseData == null)
            {
                return NotFound();
            }

            _context.AllCaseData.Remove(allCaseData);
            await _context.SaveChangesAsync();

            return allCaseData;
        }

        private bool AllCaseDataExists(int id)
        {
            return _context.AllCaseData.Any(e => e.ProjectId == id);
        }
    }
}
