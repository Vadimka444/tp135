using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Store.Models;

namespace Store.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ElectronicsController : ControllerBase
    {
        private readonly ElectronicsContext _context;

        public ElectronicsController(ElectronicsContext context)
        {
            _context = context;
        }

        // GET: api/Electronics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Electronics>>> GetElectronics()
        {
          if (_context.Electronics == null)
          {
              return NotFound();
          }
            return await _context.Electronics.ToListAsync();
        }

        // GET: api/Electronics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Electronics>> GetElectronics(int id)
        {
          if (_context.Electronics == null)
          {
              return NotFound();
          }
            var electronics = await _context.Electronics.FindAsync(id);

            if (electronics == null)
            {
                return NotFound();
            }

            return electronics;
        }

        // PUT: api/Electronics/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElectronics(int id, Electronics electronics)
        {
            if (id != electronics.Id)
            {
                return BadRequest();
            }

            _context.Entry(electronics).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElectronicsExists(id))
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

        // POST: api/Electronics
       
        [HttpPost]
        public async Task<ActionResult<Electronics>> PostElectronics(Electronics electronics)
        {
          if (_context.Electronics == null)
          {
              return Problem("Entity set 'ElectronicsContext.Electronics'  is null.");
          }
            _context.Electronics.Add(electronics);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetElectronics", new { id = electronics.Id }, electronics);
        }

        // DELETE: api/Electronics/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteElectronics(int id)
        {
            if (_context.Electronics == null)
            {
                return NotFound();
            }
            var electronics = await _context.Electronics.FindAsync(id);
            if (electronics == null)
            {
                return NotFound();
            }

            _context.Electronics.Remove(electronics);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ElectronicsExists(int id)
        {
            return (_context.Electronics?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
