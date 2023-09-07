using Aplication.Modulos.Home;
using Dto.Modulos.Home.Converter;
using Dto.Modulos.Home.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using view.Models;

namespace view.Controllers
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
            HomeDto dto = new HomeConverter().Convert(new HomeInfoQuery().DoQuery());
            ViewBag.cerveza = dto.cerveza;
            ViewBag.grados= dto.grados;
            return View();
        }

        public IActionResult Privacy()
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