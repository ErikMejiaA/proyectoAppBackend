using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class AcudienteController : BaseApiController
{
    //generamo el constructor de la clase 
    private readonly proyectoAppBackendContext _context;

    public AcudienteController(proyectoAppBackendContext context)
    {
        _context = context;
    }

    //Metodo GET para traer todos los datos de la entidad Acudiente de la Db
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Acudiente>>> Get()
    {
        var acudientes = await _context.Acudientes.ToListAsync();
        return Ok(acudientes);
    }

    //Metodo GET para traer un unico registro de la entidad Acudiente de la Db
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Get(int id)
    {
        var acudiente = await _context.Acudientes.FindAsync(id);
        return Ok(acudiente);
    }
        
}
