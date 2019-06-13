using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDMSystem.Dominio.Repository;

namespace CDMSystem.Controllers
{
    [Route("api/[Controller]")]
    public class SecretController : Controller
    {
        private readonly ISecretRepository _secretRepository;

        public SecretController(ISecretRepository secretRepository)
        {
            _secretRepository = secretRepository;
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
        public IActionResult Post([FromBody] Dominio.DTO.Secret newSecret)
        {
            try
            {
                _secretRepository.Incluid(newSecret);

                return Created("api/Secret", newSecret);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}