using Microsoft.AspNetCore.Mvc;

namespace Vendas.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
