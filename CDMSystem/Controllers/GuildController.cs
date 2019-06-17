using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDMSystem.Dominio.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CDMSystem.Controllers
{
    //[Route("[Controller]")]
    public class GuildController : Controller
    {
        private readonly IGuildRepository _guildRepository;

        public GuildController(IGuildRepository guildRepository)
        {
            _guildRepository = guildRepository;
        }

        // GET: Guild
        public ActionResult Index()
        {
            var guildsDTO = _guildRepository.GetAll();

            return View("~/Views/Principal/Guild.cshtml", guildsDTO);
        }

        // GET: Guild/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Guild/Create
        public ActionResult Create()
        {
            return View("~/Views/Cadastro/GuildCadastro.cshtml");
        }

        // POST: Guild/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Guild _guild)
        {
            try
            {
                Dominio.DTO.Guild guildDTO = new Dominio.DTO.Guild();
                guildDTO.NomeGuild = _guild.NomeGuild;
                guildDTO.DescricaoGuild = _guild.DescricaoGuild;

                _guildRepository.Incluid(guildDTO);

                Created("Guild/Create", guildDTO);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Guild/Edit/5
        public ActionResult Edit(int id)
        {
            var guildDTO = _guildRepository.GetbyId(id);

            return View("~/Views/Edicao/GuildEdicao.cshtml", guildDTO);
        }

        // POST: Guild/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Models.Guild _guild)
        {
            try
            {
                Dominio.DTO.Guild guildDTO = new Dominio.DTO.Guild();
                guildDTO.IdGuild = id;
                guildDTO.NomeGuild = _guild.NomeGuild;
                guildDTO.DescricaoGuild = _guild.DescricaoGuild;

                _guildRepository.Update(guildDTO);

                Created("Guild/Edit", guildDTO);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Guild/Delete/5
        public ActionResult Delete(int id)
        {
            Dominio.DTO.Guild guildDTO = new Dominio.DTO.Guild();
            guildDTO.IdGuild = id;
            _guildRepository.Remove(guildDTO);

            return RedirectToAction(nameof(Index));
        }
    }
}