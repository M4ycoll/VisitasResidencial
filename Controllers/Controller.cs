using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Visitas_residencial.Models;
using Visitas_residencial.Data;
namespace Visitas_residencial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CasaController : ControllerBase
    {
        private readonly YourDbContext _context;

        public CasaController(YourDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var casas = _context.Casas.ToList();
            return Ok(casas);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var casa = _context.Casas.FirstOrDefault(c => c.Id == id);
            if (casa == null)
            {
                return NotFound();
            }
            return Ok(casa);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Casa nuevaCasa)
        {
            _context.Casas.Add(nuevaCasa);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Casa casaActualizada)
        {
            var casa = _context.Casas.FirstOrDefault(c => c.Id == id);
            if (casa == null)
            {
                return NotFound();
            }
            casa.Numero = casaActualizada.Numero;
            casa.Bloque = casaActualizada.Bloque;
            casa.Calle = casaActualizada.Calle;
            casa.Referencia = casaActualizada.Referencia;
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var casa = _context.Casas.FirstOrDefault(c => c.Id == id);
            if (casa == null)
            {
                return NotFound();
            }
            _context.Casas.Remove(casa);
            _context.SaveChanges();
            return Ok();
        }
    }
}