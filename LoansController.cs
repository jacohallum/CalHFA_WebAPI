using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CalHFA.Model;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalHFA.Controllers
{

    [Route("api/[controller]")]
    public class LoansController : Controller
    {

        private readonly calhfadatabaseContext _context;

        public LoansController(calhfadatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Loans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Loans>>> GetLoans()
        {
            return await _context.Loans.ToListAsync();
        }

        // GET: api/Loans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Loans>> GetLoans(int id)
        {
            var loans = await _context.Loans.FindAsync(id);

            if (loans == null)
            {
                return NotFound();
            }

            return loans;
        }

        // PUT: api/Loans/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoans(int id, Loans loans)
        {
            if (id != loans.Id)
            {
                return BadRequest();
            }

            _context.Entry(loans).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoansExists(id))
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

        // POST: api/Loans
        [HttpPost]
        public async Task<ActionResult<Loans>> PostLoans(Loans loans)
        {
            _context.Loans.Add(loans);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoans", new { id = loans.Id }, loans);
        }

        // DELETE: api/Loans/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Loans>> DeleteLoans(int id)
        {
            var loans = await _context.Loans.FindAsync(id);
            if (loans == null)
            {
                return NotFound();
            }

            _context.Loans.Remove(loans);
            await _context.SaveChangesAsync();

            return loans;
        }

        private bool LoansExists(int id)
        {
            return _context.Loans.Any(e => e.Id == id);
        }
    }
}