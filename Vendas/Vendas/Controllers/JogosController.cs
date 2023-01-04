using Microsoft.AspNetCore.Mvc;
using Vendas.Repository;
using Vendas.Repository.Interfaces;
using Vendas.Models;

namespace Vendas.Controllers
{
    public class JogosController : Controller
    {
        private readonly IJogosRepository _jogoRepository;

        public JogosController(IJogosRepository jogoRepository)
        {
            _jogoRepository = jogoRepository;
        }
        

        public IActionResult List()
        {
            var Jogos = _jogoRepository.Jogos;
            return View(Jogos);
        }
    }
}
