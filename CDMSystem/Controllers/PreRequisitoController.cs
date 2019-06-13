using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDMSystem.Dominio.Repository;

namespace CDMSystem.Controllers
{
    [Route("api/[Controller]")]
    public class PreRequisitoController : Controller
    {
        private readonly IPreRequisitoRepository _preRequisitoRepository;

        public PreRequisitoController(IPreRequisitoRepository preRequisitoRepository)
        {
            _preRequisitoRepository = preRequisitoRepository;
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
        public IActionResult Post([FromBody] Dominio.DTO.PreRequisito newPreRequisito)
        {
            try
            {
                _preRequisitoRepository.Incluid(newPreRequisito);

                return Created("api/PreRequisito", newPreRequisito);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}