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
            serializeLogin = _loginRepository.IncluidAndReturnId(serializeLogin);

            Endereco serializeEndereco = new Endereco();
            serializeEndereco.Cep = Int32.Parse(dataRegistro["cep"]);
            serializeEndereco.Rua = dataRegistro["rua"];
            serializeEndereco.Numero = Int32.Parse(dataRegistro["numero"]);
            serializeEndereco.Referencia = dataRegistro["referencia"];
            serializeEndereco.Estado = dataRegistro["estado"];
            serializeEndereco.Cidade = dataRegistro["cidade"];
            serializeEndereco.Bairro = dataRegistro["bairro"];
            serializeEndereco.Complemento =  Int32.Parse(dataRegistro["complemento"]);
            serializeEndereco.Referencia = dataRegistro["referencia"];

            Consumidor serializeConsumidor = new Consumidor();
            serializeConsumidor.Nome = dataRegistro["nome_consumidor"];
            serializeConsumidor.Cpf = Int32.Parse(dataRegistro["cpf_consumidor"]);
            serializeConsumidor.Telefone = Int32.Parse(dataRegistro["telefone_consumidor"]);
            serializeConsumidor.Sobrenome = dataRegistro["sobrenome_consumidor"];
            serializeConsumidor.Rg = Int32.Parse(dataRegistro["rg_consumidor"]);
            serializeConsumidor.Celular = Int32.Parse(dataRegistro["celular_consumidor"]);

            Prestador serializePrestador = new Prestador();
            serializePrestador.Nome = dataRegistro["nome_prestador"];
            serializeConsumidor.Cpf = Int32.Parse(dataRegistro["cpf_prestador"]);
            serializeConsumidor.Telefone = Int32.Parse(dataRegistro["telefone_prestador"]);
            serializePrestador.Sobrenome = dataRegistro["sobrenome_prestador"];
            serializeConsumidor.Rg = Int32.Parse(dataRegistro["rg_prestador"]);
            serializeConsumidor.Celular = Int32.Parse(dataRegistro["celular_prestador"]);

            Empresa serializeEmpresa = new Empresa();
            serializeEmpresa.NomeFantasia = dataRegistro["nome_fantasia"];
            serializeEmpresa.RazaoSocial = dataRegistro["razao_social"];
            serializeEmpresa.Cnpj = Int32.Parse(dataRegistro["cnpj_empresa"]);
            serializeEmpresa.Telefone = Int32.Parse(dataRegistro["telefone_empresa"]);



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