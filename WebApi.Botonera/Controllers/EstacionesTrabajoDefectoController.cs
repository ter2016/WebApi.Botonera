using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Botonera.Classes;
using WebApi.Botonera.Context;
using WebApi.Botonera.Models;

namespace WebApi.Botonera.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstacionesTrabajoDefectoController : ControllerBase
    {
        private readonly Mikuni_BotoneraContext _context;

        public EstacionesTrabajoDefectoController(Mikuni_BotoneraContext context)
        {
            _context = context;
        }

        // POST: api/EstacionesTrabajoDefecto
        [HttpPost]
        public async Task<IActionResult> PostEstacionTrabajoDefecto([FromBody] DatoArduino datoArduino)
        {
            var defecto = await _context.Defecto.FirstOrDefaultAsync(x => x.Clave == datoArduino.ClaveDefecto);
            var idDefecto = defecto.Id;

            var estacionTrabajoDefecto = new EstacionTrabajoDefecto()
            {
                CantidadDefecto = datoArduino.CantidadDefecto,
                EstacionTrabajo = datoArduino.EstacionTrabajo,
                FechaRegistro = DateTime.Now,
                Id = 0,
                IdDefecto = idDefecto
            };

            _context.EstacionTrabajoDefecto.Add(estacionTrabajoDefecto);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}