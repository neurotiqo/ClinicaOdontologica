using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClinicaOdontologica.API.Data;
using ClinicaOdontologica.Modelos;

namespace ClinicaOdontologica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetallesCitasController : ControllerBase
    {
        private readonly ClinicaOdontologicaAPIContext _context;
        public DetallesCitasController(ClinicaOdontologicaAPIContext context)
        {
            _context = context;
        }

        // GET: api/DetallesCita
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetallesCita>>> GetDetallesCita()
        {
            return await _context.DetallesCita.ToListAsync();
        }

        // GET: api/DetallesCita/5
        [HttpGet("{iddetallescita}")]
        public async Task<ActionResult<DetallesCita>> GetDetallesCita(int iddetallescita)
        {
            var detallescita = await _context.DetallesCita.FindAsync(iddetallescita);

            if (detallescita == null)
            {
                return NotFound();
            }

            return detallescita;
        }

        // PUT: api/DetallesCita/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{iddetallescita}")]
        public async Task<IActionResult> PutDetallesCita(int? iddetallescita, DetallesCita detallescita)
        {
            if (iddetallescita != detallescita.IdDetallesCita)
            {
                return BadRequest();
            }

            _context.Entry(detallescita).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetallesCitaExists(iddetallescita))
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

        // POST: api/DetallesCita
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DetallesCita>> PostDetallesCita(DetallesCita detallescita)
        {
            _context.DetallesCita.Add(detallescita);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetallesCita", new { iddetallescita = detallescita.IdDetallesCita }, detallescita);
        }

        // DELETE: api/DetallesCita/5
        [HttpDelete("{iddetallescita}")]
        public async Task<IActionResult> DeleteDetallesCita(int? iddetallescita)
        {
            var detallescita = await _context.DetallesCita.FindAsync(iddetallescita);
            if (detallescita == null)
            {
                return NotFound();
            }

            _context.DetallesCita.Remove(detallescita);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetallesCitaExists(int? iddetallescita)
        {
            return _context.DetallesCita.Any(e => e.IdDetallesCita == iddetallescita);
        }
    }
}