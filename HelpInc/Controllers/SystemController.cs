using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelpInc.Controllers
{
    public class SystemController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/System/Index.cshtml");
        }
    }
}