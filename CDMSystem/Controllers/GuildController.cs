using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CDMSystem.Controllers
{
    public class GuildController : Controller
    {
        // GET: Guild
        public ActionResult Index()
        {
            return View("~/Views/Principal/Guild.cshtml");
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
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("~/Views/Cadastro/GuildCadastro.cshtml");
            }
        }

        // GET: Guild/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Guild/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
            return View();
        }

        // POST: Guild/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}