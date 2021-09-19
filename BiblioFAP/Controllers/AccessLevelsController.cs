using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BiblioFAP.Conf;
using BiblioFAP.Models;

namespace BiblioFAP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "1")]
    public class AccessLevelsController : ControllerBase
    {
        private readonly Database _context;

        public AccessLevelsController(Database context)
        {
            _context = context;
        }

        // GET: api/AccessLevels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccessLevel>>> GetAccessLevel()
        {
            return await _context.AccessLevel.ToListAsync();
        }

        // GET: api/AccessLevels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AccessLevel>> GetAccessLevel(int id)
        {
            var accessLevel = await _context.AccessLevel.FindAsync(id);

            if (accessLevel == null)
            {
                return NotFound();
            }

            return accessLevel;
        }

        // PUT: api/AccessLevels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccessLevel(int id, AccessLevel accessLevel)
        {
            if (id != accessLevel.Id)
            {
                return BadRequest();
            }

            _context.Entry(accessLevel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccessLevelExists(id))
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

        // POST: api/AccessLevels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AccessLevel>> PostAccessLevel(AccessLevel accessLevel)
        {
            _context.AccessLevel.Add(accessLevel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAccessLevel", new { id = accessLevel.Id }, accessLevel);
        }

        // DELETE: api/AccessLevels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccessLevel(int id)
        {
            var accessLevel = await _context.AccessLevel.FindAsync(id);
            if (accessLevel == null)
            {
                return NotFound();
            }

            _context.AccessLevel.Remove(accessLevel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AccessLevelExists(int id)
        {
            return _context.AccessLevel.Any(e => e.Id == id);
        }
    }
}
