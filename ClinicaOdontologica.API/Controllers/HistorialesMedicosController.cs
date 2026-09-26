using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClinicaOdontologica.Modelos;

[Route("api/[controller]")]
[ApiController]
public class HistorialesMedicosController : ControllerBase
{
    private readonly ClinicaOdontologicaAPIContext _context;
    public HistorialesMedicosController(ClinicaOdontologicaAPIContext context)
    {
        _context = context;
    }

    // GET: api/HistorialMedico
    [HttpGet]
    public async Task<ActionResult<IEnumerable<HistorialMedico>>> GetHistorialMedico()
    {
        return await _context.HistorialMedico.ToListAsync();
    }

    // GET: api/HistorialMedico/5
    [HttpGet("{idhistorial}")]
    public async Task<ActionResult<HistorialMedico>> GetHistorialMedico(int idhistorial)
    {
        var historialmedico = await _context.HistorialMedico.FindAsync(idhistorial);

        if (historialmedico == null)
        {
            return NotFound();
        }

        return historialmedico;
    }

    // PUT: api/HistorialMedico/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{idhistorial}")]
    public async Task<IActionResult> PutHistorialMedico(int? idhistorial, HistorialMedico historialmedico)
    {
        if (idhistorial != historialmedico.IdHistorial)
        {
            return BadRequest();
        }

        _context.Entry(historialmedico).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!HistorialMedicoExists(idhistorial))
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

    // POST: api/HistorialMedico
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<HistorialMedico>> PostHistorialMedico(HistorialMedico historialmedico)
    {
        _context.HistorialMedico.Add(historialmedico);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetHistorialMedico", new { idhistorial = historialmedico.IdHistorial }, historialmedico);
    }

    // DELETE: api/HistorialMedico/5
    [HttpDelete("{idhistorial}")]
    public async Task<IActionResult> DeleteHistorialMedico(int? idhistorial)
    {
        var historialmedico = await _context.HistorialMedico.FindAsync(idhistorial);
        if (historialmedico == null)
        {
            return NotFound();
        }

        _context.HistorialMedico.Remove(historialmedico);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool HistorialMedicoExists(int? idhistorial)
    {
        return _context.HistorialMedico.Any(e => e.IdHistorial == idhistorial);
    }
}
