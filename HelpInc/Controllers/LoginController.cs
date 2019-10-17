using System;
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

            Login entityLogin = _loginRepository.Logar(serializeLogin);

            if (entityLogin.Id != 0 && entityLogin.Email != null && entityLogin.Senha != null)
            {
                string jsonEntity = string.Empty;
                long idEndereco = 0;

                // Dados para a Viewbag
                string nome = string.Empty;

                switch (entityLogin.Tipo)
                {
                    case 'C':
                        Consumidor entityConsumidor = _consumidorRepository.GetbyIdLogin(entityLogin.Id);
                        idEndereco = entityConsumidor.IdEndereco;
                        nome = entityConsumidor.Nome;

                        jsonEntity = JsonConvert.SerializeObject(entityConsumidor);
                        HttpContext.Session.SetString("Tipo", "Consumidor");
                        break;
                    case 'P':
                        Prestador entityPrestador = _prestadorRepository.GetbyIdLogin(entityLogin.Id);
                        idEndereco = entityPrestador.IdEndereco;
                        nome = entityPrestador.Nome;

                        jsonEntity = JsonConvert.SerializeObject(entityPrestador);
                        HttpContext.Session.SetString("Tipo", "Prestador");
                        break;
                    case 'E':
                        Empresa entityEmpresa = _empresaRepository.GetbyIdLogin(entityLogin.Id);
                        idEndereco = entityEmpresa.IdEndereco;
                        nome = entityEmpresa.NomeFantasia;

                        jsonEntity = JsonConvert.SerializeObject(entityEmpresa);
                        HttpContext.Session.SetString("Tipo", "Empresa");
                        break;
                }

                ViewBag.Nome = nome;

                Endereco entityEndereco = _enderecoRepository.GetbyIdEndereco(idEndereco);
                HttpContext.Session.SetString("DadosUsuario", jsonEntity);

                string jsonEndereco = JsonConvert.SerializeObject(entityEndereco);
                HttpContext.Session.SetString("DadosEndereco", jsonEndereco);

                return View("~/Views/System/Index.cshtml");
            }
            else if(entityLogin.Id == 0)
            {
                ViewBag["Erro"] = "Conta não registrada!";
            }
            else if (entityLogin.Tipo != 'C' && entityLogin.Tipo != 'P' && entityLogin.Tipo != 'E')
            {
                ViewBag["Erro"] = "Tipo de conta inválido!";
            }

            return View("~/Views/Login/Index.cshtml");
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