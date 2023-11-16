using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LuNascimento.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

         public IActionResult Products()
        {
            return View();
        }

        public IActionResult Aromas()
        {
            return View();
        }
           public IActionResult Exclusivos()
        {
            return View();
        }
           public IActionResult Aromaterapia()
        {
            return View();
        }           
         public IActionResult Outros()
        {
            return View();
        }
         public IActionResult Sache()
        {
            return View();
        }
         public IActionResult Carro()
        {
            return View();
        }
         public IActionResult Spray()
        {
            return View();
        }
         public IActionResult Lencol()
        {
            return View();
        }
         public IActionResult Sabonete()
        {
            return View();
        }

         public IActionResult QuemSomos()
        {
            return View();
        }
        public IActionResult Detalhes()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}