using DataBase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly MyDbContext _context;

        public ClassController(MyDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        // GET: api/Cars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> Getstudent()
        {
            return await _context.Clases.ToListAsync();
        }

        // GET: api/Cars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Class>> Getstudent(int id)
        {
            var sinifs = await _context.Clases.FindAsync(id);

            if (sinifs == null)
            {
                return NotFound();
            }

            return sinifs;
        }

        // PUT: api/Cars/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putstudent(int id, Class sinif)
        {
            if (id != sinif.Id)
            {
                return BadRequest();
            }

            _context.Entry(sinif).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(id))
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

        // POST: api/Cars
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Class>> Poststudent(Class sinifm)
        {
            _context.Clases.Add(sinifm);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Sınıflar", new { id = sinifm.Id }, sinifm);
        }

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletestudent(int id)
        {
            var sinif = await _context.Clases.FindAsync(id);
            if (sinif == null)
            {
                return NotFound();
            }

            _context.Clases.Remove(sinif);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarExists(int id)
        {
            return _context.Clases.Any(e => e.Id == id);
        }
    }
}
