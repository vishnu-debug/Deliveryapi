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
    public class UserreqsController : ControllerBase
    {
        private readonly Customercontext _context;

        public UserreqsController(Customercontext context)
        {
            _context = context;
        }

        // GET: api/Userreqs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Userreq>>> GetUserreq()
        {
            return await _context.Userreq.ToListAsync();
        }

        // GET: api/Userreqs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Userreq>> GetUserreq(int id)
        {
            var userreq = await _context.Userreq.FindAsync(id);

            if (userreq == null)
            {
                return NotFound();
            }

            return userreq;
        }

        // PUT: api/Userreqs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserreq(int id, Userreq userreq)
        {
            if (id != userreq.RequestID)
            {
                return BadRequest();
            }

            _context.Entry(userreq).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserreqExists(id))
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

        // POST: api/Userreqs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Userreq>> PostUserreq(Userreq userreq)
        {
            _context.Userreq.Add(userreq);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserreq", new { id = userreq.RequestID }, userreq);
        }

        // DELETE: api/Userreqs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserreq(int id)
        {
            var userreq = await _context.Userreq.FindAsync(id);
            if (userreq == null)
            {
                return NotFound();
            }

            _context.Userreq.Remove(userreq);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserreqExists(int id)
        {
            return _context.Userreq.Any(e => e.RequestID == id);
        }
    }
}
