﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Servicios.api.Libreria.Core.Entities;
using Servicios.api.Libreria.Repository;

namespace Servicios.api.Libreria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibreriaServicioController : ControllerBase
    {
        private readonly IAutorRepository _autorRepository;

        public  LibreriaServicioController(IAutorRepository autorRepository){
           _autorRepository = autorRepository;
                
        }

        [HttpGet("autores")]

        public async Task<ActionResult<IEnumerable<Autor>>> GetAutores()
        {
            var autores = await _autorRepository.GetAutores();
            return Ok(autores);
        }

    }
}
