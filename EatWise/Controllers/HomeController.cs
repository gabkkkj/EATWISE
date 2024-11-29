using EatWise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EatWise.Controllers
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
            var dietaSelecionada = Request.Query["dieta"];
            ViewData["DietaSelecionada"] = dietaSelecionada; // Passa para a view
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Quemsomos()
        {
            return View();
        }

        public IActionResult MeuFoco()
        {
            return View();
        }

        public IActionResult Planos()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
