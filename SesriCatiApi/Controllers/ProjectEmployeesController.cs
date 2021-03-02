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
    public class ProjectEmployeesController : ControllerBase
    {
        private readonly sesriDBContext _context;

        public ProjectEmployeesController(sesriDBContext context)
        {
            _context = context;
        }

        // GET: api/ProjectEmployees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectEmployee>>> GetProjectEmployee()
        {
            return await _context.ProjectEmployee.ToListAsync();
        }

        // GET: api/ProjectEmployees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectEmployee>> GetProjectEmployee(int id)
        {
            var projectEmployee = await _context.ProjectEmployee.FindAsync(id);

            if (projectEmployee == null)
            {
                return NotFound();
            }

            return projectEmployee;
        }

        // PUT: api/ProjectEmployees/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProjectEmployee(int id, ProjectEmployee projectEmployee)
        {
            if (id != projectEmployee.Id)
            {
                return BadRequest();
            }

            _context.Entry(projectEmployee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectEmployeeExists(id))
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

        // POST: api/ProjectEmployees
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProjectEmployee>> PostProjectEmployee(ProjectEmployee projectEmployee)
        {
            _context.ProjectEmployee.Add(projectEmployee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProjectEmployee", new { id = projectEmployee.Id }, projectEmployee);
        }

        // DELETE: api/ProjectEmployees/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProjectEmployee>> DeleteProjectEmployee(int id)
        {
            var projectEmployee = await _context.ProjectEmployee.FindAsync(id);
            if (projectEmployee == null)
            {
                return NotFound();
            }

            _context.ProjectEmployee.Remove(projectEmployee);
            await _context.SaveChangesAsync();

            return projectEmployee;
        }

        private bool ProjectEmployeeExists(int id)
        {
            return _context.ProjectEmployee.Any(e => e.Id == id);
        }
    }
}
