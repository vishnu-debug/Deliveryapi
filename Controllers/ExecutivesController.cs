using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Deliveryapi.Data;
using Deliveryapi.Model;

namespace Deliveryapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExecutivesController : ControllerBase
    {
        private readonly Customercontext _context;

        public ExecutivesController(Customercontext context)
        {
            _context = context;
        }

        // GET: api/Executives
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Executive>>> GetExecutive()
        {
            return await _context.Executive.ToListAsync();
        }

        // GET: api/Executives/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Executive>> GetExecutive(int id)
        {
            var executive = await _context.Executive.FindAsync(id);

            if (executive == null)
            {
                return NotFound();
            }

            return executive;
        }

        // PUT: api/Executives/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExecutive(int id, Executive executive)
        {
            if (id != executive.ExecutiveID)
            {
                return BadRequest();
            }

            _context.Entry(executive).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExecutiveExists(id))
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

        // POST: api/Executives
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Executive>> PostExecutive(Executive executive)
        {
            _context.Executive.Add(executive);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExecutive", new { id = executive.ExecutiveID }, executive);
        }

        // DELETE: api/Executives/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExecutive(int id)
        {
            var executive = await _context.Executive.FindAsync(id);
            if (executive == null)
            {
                return NotFound();
            }

            _context.Executive.Remove(executive);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExecutiveExists(int id)
        {
            return _context.Executive.Any(e => e.ExecutiveID == id);
        }
    }
}
