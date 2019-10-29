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
    public class RegistroController : Controller
    {
        private readonly ILoginRepository _loginRepository;
        private readonly IEmpresaRepository _empresaRepository;
        private readonly IPrestadorRepository _prestadorRepository;
        private readonly IConsumidorRepository _consumidorRepository;
        private readonly IEnderecoRepository _enderecoRepository;

        public RegistroController(ILoginRepository loginRepository, IPrestadorRepository prestadorRepository, IEmpresaRepository empresaRepository,
            IConsumidorRepository consumidorRepository, IEnderecoRepository enderecoRepository)
        {
            _loginRepository = loginRepository;
            _empresaRepository = empresaRepository;
            _prestadorRepository = prestadorRepository;
            _consumidorRepository = consumidorRepository;
            _enderecoRepository = enderecoRepository;
        }
        // GET: Registro
        public ActionResult Index()
        {
            return View("~/Views/Registro/Index.cshtml");
        }

        // POST: Registro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection dataRegistro)
        {
            Login serializeLogin = new Login();
            serializeLogin.Email = dataRegistro["email"];
            serializeLogin.Senha = dataRegistro["password"];

            Endereco serializeEndereco = new Endereco();
            //serializeEndereco.Cep = dataRegistro["cep"];
            serializeEndereco.Rua = dataRegistro["rua"];
            //serializeEndereco.Numero = dataRegistro["numero"];
            serializeEndereco.Referencia = dataRegistro["referencia"];
            serializeEndereco.Estado = dataRegistro["estado"];
            serializeEndereco.Cidade = dataRegistro["cidade"];
            serializeEndereco.Bairro = dataRegistro["bairro"];
            //serializeEndereco.Complemento = dataRegistro["complemento"];
            serializeEndereco.Referencia = dataRegistro["referencia"];

            Consumidor serializeConsumidor = new Consumidor();
            serializeConsumidor.Nome = dataRegistro["nome"];
            //serializeConsumidor.Cpf = dataRegistro["cpf"];
            //serializeConsumidor.Telefone = dataRegistro["telefone"];
            serializeConsumidor.Sobrenome = dataRegistro["sobrenome"];
            //serializeConsumidor.Rg = dataRegistro["rg"];
            //serializeConsumidor.Celular = dataRegistro["celular"];
            serializeConsumidor.Nome = dataRegistro["nome"];

            Prestador serializePrestador = new Prestador();
            serializePrestador.Nome = dataRegistro["nome"];
            //serializePrestador.Cpf = dataRegistro["cpf"];
            //serializePrestador.Telefone = dataRegistro["telefone"];
            serializePrestador.Sobrenome = dataRegistro["sobrenome"];
            //serializePrestador.Rg = dataRegistro["rg"];
            //serializePrestador.Celular = dataRegistro["celular"];
            serializePrestador.Nome = dataRegistro["nome"];

            Empresa serializeEmpresa = new Empresa();
            serializeEmpresa.NomeFantasia = dataRegistro["nome_fantasia"];
            serializeEmpresa.RazaoSocial = dataRegistro["razao_social"];
            //serializeEmpresa.Cnpj = dataRegistro["cnpj"];
            //serializeEmpresa.Telefone = dataRegistro["telefone"];




            return View("~/Views/Login/Index.cshtml");
        }

        // POST: Registro/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Registro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Registro/Edit/5
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

        // POST: Registro/Delete/5
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