using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Botonera.Context;
using WebApi.Botonera.Models;
using WebApi.Botonera.DTOs;
using AutoMapper;

namespace WebApi.Botonera.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefectosController : ControllerBase
    {
        private readonly Mikuni_BotoneraContext _context;

        public DefectosController(Mikuni_BotoneraContext context)
        {
            _context = context;
        }

        // GET: api/Defectos/CVE1234
        [HttpGet("{clave}")]
        public async Task<IActionResult> GetDefecto([FromRoute] string clave)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var defecto = await _context.Defecto.FirstOrDefaultAsync(x => x.Clave == clave);

            if (defecto == null)
            {
                return NotFound();
            }

            return Ok(defecto.Nombre);
        }
    }
}