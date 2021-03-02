using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SesriCatiApi.Models;

namespace SesriCatiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueViewsController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public IssueViewsController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/IssueViews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IssueView>>> GetIssueView()
        {
            return await _context.IssueView.ToListAsync();
        }

        // GET: api/IssueViews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IssueView>> GetIssueView(int? id)
        {
            var issueView = await _context.IssueView.FindAsync(id);

            if (issueView == null)
            {
                return NotFound();
            }

            return issueView;
        }

        // PUT: api/IssueViews/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIssueView(int? id, IssueView issueView)
        {
            if (id != issueView.UniqueId)
            {
                return BadRequest();
            }

            _context.Entry(issueView).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IssueViewExists(id))
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

        // POST: api/IssueViews
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<IssueView>> PostIssueView(IssueView issueView)
        {
            _context.IssueView.Add(issueView);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (IssueViewExists(issueView.UniqueId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetIssueView", new { id = issueView.UniqueId }, issueView);
        }

        // DELETE: api/IssueViews/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IssueView>> DeleteIssueView(int? id)
        {
            var issueView = await _context.IssueView.FindAsync(id);
            if (issueView == null)
            {
                return NotFound();
            }

            _context.IssueView.Remove(issueView);
            await _context.SaveChangesAsync();

            return issueView;
        }

        private bool IssueViewExists(int? id)
        {
            return _context.IssueView.Any(e => e.UniqueId == id);
        }
    }
}
