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
    public class DailyReportsController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public DailyReportsController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/DailyReports
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DailyReport>>> GetDailyReport()
        {
            return await _context.DailyReport.ToListAsync();
        }

        // GET: api/DailyReports/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DailyReport>> GetDailyReport(int id)
        {
            var dailyReport = await _context.DailyReport.FindAsync(id);

            if (dailyReport == null)
            {
                return NotFound();
            }

            return dailyReport;
        }

        // PUT: api/DailyReports/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDailyReport(int id, DailyReport dailyReport)
        {
            if (id != dailyReport.Id)
            {
                return BadRequest();
            }

            _context.Entry(dailyReport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DailyReportExists(id))
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

        // POST: api/DailyReports
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DailyReport>> PostDailyReport(DailyReport dailyReport)
        {
            _context.DailyReport.Add(dailyReport);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DailyReportExists(dailyReport.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDailyReport", new { id = dailyReport.Id }, dailyReport);
        }

        // DELETE: api/DailyReports/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DailyReport>> DeleteDailyReport(int id)
        {
            var dailyReport = await _context.DailyReport.FindAsync(id);
            if (dailyReport == null)
            {
                return NotFound();
            }

            _context.DailyReport.Remove(dailyReport);
            await _context.SaveChangesAsync();

            return dailyReport;
        }

        private bool DailyReportExists(int id)
        {
            return _context.DailyReport.Any(e => e.Id == id);
        }
    }
}
