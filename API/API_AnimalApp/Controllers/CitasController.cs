using API_AnimalApp.Data;
using API_AnimalApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class CitasController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CitasController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CrearCita([FromBody] Cita cita)
    {
        _context.Citas.Add(cita);
        await _context.SaveChangesAsync();
        return Ok(cita);
    }

    [HttpGet]
    public async Task<IActionResult> ObtenerCitas()
    {
        var citas = await _context.Citas.ToListAsync();
        return Ok(citas);
    }
}
