using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDMSystem.Dominio.Repository;

namespace CDMSystem.Controllers
{
    [Route("api/[Controller]")]
    public class GuildApiController : Controller
    {
        private readonly IGuildRepository _guildRepository;

        public GuildApiController(IGuildRepository guildRepository)
        {
            _guildRepository = guildRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_guildRepository.GetAll());

                //var resp = true;

                //if (resp == true)
                //{
                //    return Ok(_guildRepository.GetAll());
                //}
                //else
                //{
                //    return BadRequest("");
                //}
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Dominio.DTO.Guild newGuild)
        {
            try
            {
                _guildRepository.Incluid(newGuild);

                return Created("api/Guild", newGuild);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}