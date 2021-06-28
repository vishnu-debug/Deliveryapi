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
    public class ExecutiveresController : ControllerBase
    {
        private readonly Customercontext _context;

        public ExecutiveresController(Customercontext context)
        {
            _context = context;
        }

        // GET: api/Executiveres
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Executiveres>>> GetExecutiveres()
        {
            return await _context.Executiveres.ToListAsync();
        }

        // GET: api/Executiveres/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Executiveres>> GetExecutiveres(int id)
        {
            var executiveres = await _context.Executiveres.FindAsync(id);

            if (executiveres == null)
            {
                return NotFound();
            }

            return executiveres;
        }

        // PUT: api/Executiveres/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExecutiveres(int id, Executiveres executiveres)
        {
            if (id != executiveres.ExrequestID)
            {
                return BadRequest();
            }

            _context.Entry(executiveres).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExecutiveresExists(id))
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

        // POST: api/Executiveres
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Executiveres>> PostExecutiveres(Executiveres executiveres)
        {
            _context.Executiveres.Add(executiveres);
             await _context.SaveChangesAsync();

            return CreatedAtAction("GetExecutiveres", new { id = executiveres.ExrequestID }, executiveres);
        }

        // DELETE: api/Executiveres/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExecutiveres(int id)
        {
            var executiveres = await _context.Executiveres.FindAsync(id);
            if (executiveres == null)
            {
                return NotFound();
            }

            _context.Executiveres.Remove(executiveres);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExecutiveresExists(int id)
        {
            return _context.Executiveres.Any(e => e.ExrequestID == id);
        }
    }
}
