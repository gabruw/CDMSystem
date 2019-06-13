using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDMSystem.Dominio.Repository;

namespace CDMSystem.Controllers
{
    [Route("api/[Controller]")]
    public class PersonagemController : Controller
    {
        private readonly IPersonagemRepository _personagemRepository;

        public PersonagemController(IPersonagemRepository personagemRepository)
        {
            _personagemRepository = personagemRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var resp = true;

                if (resp == true)
                {
                    return Ok("");
                }
                else
                {
                    return BadRequest("");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Dominio.DTO.Personagem newPersonagem)
        {
            try
            {
                _personagemRepository.Incluid(newPersonagem);

                return Created("api/Personagem", newPersonagem);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}