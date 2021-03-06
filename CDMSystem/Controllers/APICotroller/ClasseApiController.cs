﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDMSystem.Dominio.Repository;

namespace CDMSystem.Controllers
{
    [Route("api/[Controller]")]
    public class ClasseApiController : Controller
    {
        private readonly IClasseRepository _classeRepository;

        public ClasseApiController(IClasseRepository classeRepository)
        {
            _classeRepository = classeRepository;
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
        public IActionResult Post([FromBody] Dominio.DTO.Classe newClasse)
        {
            try
            {
                _classeRepository.Incluid(newClasse);

                return Created("api/Classe", newClasse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}