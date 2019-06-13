using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDMSystem.Dominio.Repository;

namespace CDMSystem.Controllers
{
    [Route("api/[Controller]")]
    public class OminiSkillController : Controller
    {
        private readonly IOminiSkillRepository _ominiSkillRepository;

        public OminiSkillController(IOminiSkillRepository ominiSkillRepository)
        {
            _ominiSkillRepository = ominiSkillRepository;
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
        public IActionResult Post([FromBody] Dominio.DTO.OminiSkill newOminiSkill)
        {
            try
            {
                _ominiSkillRepository.Incluid(newOminiSkill);

                return Created("api/OminiSkill", newOminiSkill);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}