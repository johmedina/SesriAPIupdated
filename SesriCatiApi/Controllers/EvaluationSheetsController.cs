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
    public class EvaluationSheetsController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public EvaluationSheetsController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/EvaluationSheets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EvaluationSheet>>> GetEvaluationSheet()
        {
            return await _context.EvaluationSheet.ToListAsync();
        }

        // GET: api/EvaluationSheets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EvaluationSheet>> GetEvaluationSheet(int id)
        {
            var evaluationSheet = await _context.EvaluationSheet.FindAsync(id);

            if (evaluationSheet == null)
            {
                return NotFound();
            }

            return evaluationSheet;
        }

        // PUT: api/EvaluationSheets/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvaluationSheet(int id, EvaluationSheet evaluationSheet)
        {
            if (id != evaluationSheet.Id)
            {
                return BadRequest();
            }

            _context.Entry(evaluationSheet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EvaluationSheetExists(id))
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

        // POST: api/EvaluationSheets
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EvaluationSheet>> PostEvaluationSheet(EvaluationSheet evaluationSheet)
        {
            _context.EvaluationSheet.Add(evaluationSheet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEvaluationSheet", new { id = evaluationSheet.Id }, evaluationSheet);
        }

        // DELETE: api/EvaluationSheets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EvaluationSheet>> DeleteEvaluationSheet(int id)
        {
            var evaluationSheet = await _context.EvaluationSheet.FindAsync(id);
            if (evaluationSheet == null)
            {
                return NotFound();
            }

            _context.EvaluationSheet.Remove(evaluationSheet);
            await _context.SaveChangesAsync();

            return evaluationSheet;
        }

        private bool EvaluationSheetExists(int id)
        {
            return _context.EvaluationSheet.Any(e => e.Id == id);
        }
    }
}
