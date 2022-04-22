using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApiPostCrearHumano.Data;
using ApiPostCrearHumano.Model;

namespace ApiPostCrearHumano.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HumanosController : ControllerBase
    {
        private readonly ApiPostCrearHumanoContext _context;

        public HumanosController(ApiPostCrearHumanoContext context)
        {
            _context = context;
        }

        // POST: Humanoes/Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Sexo,Edad,Altura,Peso")] Humano humano)
        {
            if (ModelState.IsValid)
            {
                _context.Add(humano);
                await _context.SaveChangesAsync();
                return Ok(humano);
            }
            else
                return BadRequest(404);
           
        }
    }
}
