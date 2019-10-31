using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HelpInc.Controllers
{
    public class SystemController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/System/Index.cshtml");
        }

        public IActionResult Perfil()
        {
            return View("~/Views/Perfil/Index.cshtml");
        }
    }
}