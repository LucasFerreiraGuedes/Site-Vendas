using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Vendas.Models;
using Vendas.Repository.Interfaces;

namespace Vendas.Controllers
{
    public class HomeController : Controller
    {
       // private readonly ILogger<HomeController> _logger;
        private readonly IJogosRepository _jogosRepository;

        public HomeController(IJogosRepository jogosRepository)
        {
            _jogosRepository= jogosRepository;
        }

      /*  public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
      */

        public IActionResult Index()
        {

            var homeViewModel = new HomeViewModel
            {
                JogosPreferidos = _jogosRepository.JogosPreferidos
            };
            return View(homeViewModel);
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