using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDMSystem.Dominio.Repository;

namespace CDMSystem.Controllers
{
    [Route("api/[Controller]")]
    public class ActiveSkillApiController : Controller
    {
        private readonly IActiveSkillRepository _activeSkillRepository;

        public ActiveSkillApiController(IActiveSkillRepository activeSkillRepository)
        {
            _activeSkillRepository = activeSkillRepository;
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
        public IActionResult Post([FromBody] Dominio.DTO.ActiveSkill newActiveSkill)
        {
            try
            {
                _activeSkillRepository.Incluid(newActiveSkill);

                return Created("api/ActiveSkill", newActiveSkill);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}