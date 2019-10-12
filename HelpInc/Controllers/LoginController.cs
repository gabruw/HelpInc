﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HelpInc.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginRepository _loginRepository;
        private readonly IEmpresaRepository _empresaRepository;
        private readonly IPrestadorRepository _prestadorRepository;
        private readonly IConsumidorRepository _consumidorRepository;
        private readonly IEnderecoRepository _enderecoRepository;

        public LoginController(ILoginRepository loginRepository, IPrestadorRepository prestadorRepository, IEmpresaRepository empresaRepository, 
            IConsumidorRepository consumidorRepository, IEnderecoRepository enderecoRepository)
        {
            _loginRepository = loginRepository;
            _empresaRepository = empresaRepository;
            _prestadorRepository = prestadorRepository;
            _consumidorRepository = consumidorRepository;
            _enderecoRepository = enderecoRepository;
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
            serializeLogin.Email = dataLogin["email"];
            serializeLogin.Senha = dataLogin["password"];

            Login entitylogin = _loginRepository.Logar(serializeLogin);

            if (entitylogin.Id != 0 && entitylogin.Email != null && entitylogin.Senha != null)
            {
                string json = string.Empty;
                switch (entitylogin.Tipo)
                {
                    case 'C':
                        Consumidor entityConsumidor = _consumidorRepository.GetbyIdLogin(entitylogin.Id);

                        json = JsonConvert.SerializeObject(entityConsumidor);
                        HttpContext.Session.SetString("DataConsumidor", json);
                        break;
                    case 'P':
                        Prestador entityPrestador = _prestadorRepository.GetbyIdLogin(entitylogin.Id);

                        json = JsonConvert.SerializeObject(entityPrestador);
                        HttpContext.Session.SetString("DataPrestador", json);
                        break;
                    case 'E':
                        Empresa entityEmpresa = _empresaRepository.GetbyIdLogin(entitylogin.Id);

                        json = JsonConvert.SerializeObject(entityEmpresa);
                        HttpContext.Session.SetString("DataEmpresa", json);
                        break;
                }

                
                //Endereco entityEndereco = _enderecoRepository.GetbyIdEndereco();

                return View("~/Views/Login/Index.cshtml");
            }
            else if(entitylogin.Id == 0)
            {
                ViewBag["Erro"] = "Conta não registrada!";
            }
            else if (entitylogin.Tipo != 'C' && entitylogin.Tipo != 'P' && entitylogin.Tipo != 'E')
            {
                ViewBag["Erro"] = "Tipo de conta inválido!";
            }

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