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
    public class DimEvaluationCriteriasController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public DimEvaluationCriteriasController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/DimEvaluationCriterias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimEvaluationCriteria>>> GetDimEvaluationCriteria()
        {
            return await _context.DimEvaluationCriteria.ToListAsync();
        }

        // GET: api/DimEvaluationCriterias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimEvaluationCriteria>> GetDimEvaluationCriteria(int id)
        {
            var dimEvaluationCriteria = await _context.DimEvaluationCriteria.FindAsync(id);

            if (dimEvaluationCriteria == null)
            {
                return NotFound();
            }

            return dimEvaluationCriteria;
        }

        // PUT: api/DimEvaluationCriterias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDimEvaluationCriteria(int id, DimEvaluationCriteria dimEvaluationCriteria)
        {
            if (id != dimEvaluationCriteria.Id)
            {
                return BadRequest();
            }

            _context.Entry(dimEvaluationCriteria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DimEvaluationCriteriaExists(id))
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

        // POST: api/DimEvaluationCriterias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DimEvaluationCriteria>> PostDimEvaluationCriteria(DimEvaluationCriteria dimEvaluationCriteria)
        {
            _context.DimEvaluationCriteria.Add(dimEvaluationCriteria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDimEvaluationCriteria", new { id = dimEvaluationCriteria.Id }, dimEvaluationCriteria);
        }

        // DELETE: api/DimEvaluationCriterias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DimEvaluationCriteria>> DeleteDimEvaluationCriteria(int id)
        {
            var dimEvaluationCriteria = await _context.DimEvaluationCriteria.FindAsync(id);
            if (dimEvaluationCriteria == null)
            {
                return NotFound();
            }

            _context.DimEvaluationCriteria.Remove(dimEvaluationCriteria);
            await _context.SaveChangesAsync();

            return dimEvaluationCriteria;
        }

        private bool DimEvaluationCriteriaExists(int id)
        {
            return _context.DimEvaluationCriteria.Any(e => e.Id == id);
        }
    }
}
