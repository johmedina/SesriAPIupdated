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
    public class EvaluationScoresController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public EvaluationScoresController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/EvaluationScores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EvaluationScore>>> GetEvaluationScore()
        {
            return await _context.EvaluationScore.ToListAsync();
        }

        // GET: api/EvaluationScores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EvaluationScore>> GetEvaluationScore(int id)
        {
            var evaluationScore = await _context.EvaluationScore.FindAsync(id);

            if (evaluationScore == null)
            {
                return NotFound();
            }

            return evaluationScore;
        }

        // PUT: api/EvaluationScores/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvaluationScore(int id, EvaluationScore evaluationScore)
        {
            if (id != evaluationScore.Id)
            {
                return BadRequest();
            }

            _context.Entry(evaluationScore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EvaluationScoreExists(id))
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

        // POST: api/EvaluationScores
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EvaluationScore>> PostEvaluationScore(EvaluationScore evaluationScore)
        {
            _context.EvaluationScore.Add(evaluationScore);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEvaluationScore", new { id = evaluationScore.Id }, evaluationScore);
        }

        // DELETE: api/EvaluationScores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EvaluationScore>> DeleteEvaluationScore(int id)
        {
            var evaluationScore = await _context.EvaluationScore.FindAsync(id);
            if (evaluationScore == null)
            {
                return NotFound();
            }

            _context.EvaluationScore.Remove(evaluationScore);
            await _context.SaveChangesAsync();

            return evaluationScore;
        }

        private bool EvaluationScoreExists(int id)
        {
            return _context.EvaluationScore.Any(e => e.Id == id);
        }
    }
}
