using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelpInc.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginRepository _loginRepository;

        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        // GET: Login
        public ActionResult Index()
        {
            return View("~/Views/Login/Index.cshtml");
        }

        // POST: Login/Logar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logar(IFormCollection dataLogin)
        {
            Login serializeLogin = new Login();
            serializeLogin.Email = dataLogin["login"];
            serializeLogin.Senha = dataLogin["password"];

            Login entitylogin = _loginRepository.Logar(serializeLogin);

            ////if ()
            ////{

            //}

            return View("~/Views/System/Index.cshtml", entitylogin);
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
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
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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
    }
}