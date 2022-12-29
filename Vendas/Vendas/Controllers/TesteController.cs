using Microsoft.AspNetCore.Mvc;

namespace Vendas.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
