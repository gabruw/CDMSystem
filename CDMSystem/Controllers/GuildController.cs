using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CDMSystem.Models;

namespace CDMSystem.Controllers
{
    [Route("[controller]")]
    public class GuildController : Controller
    {
        [Route("[action]")]
        public IActionResult GuildCadastro()
        {
            return View("~/Views/Cadastro/GuildCadastro.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
