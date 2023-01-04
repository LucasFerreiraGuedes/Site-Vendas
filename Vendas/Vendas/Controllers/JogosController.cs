using Microsoft.AspNetCore.Mvc;
using Vendas.Repository;
using Vendas.Repository.Interfaces;
using Vendas.Models;
using Vendas.ViewModels;

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
            //var Jogos = _jogoRepository.Jogos;
            //return View(Jogos);

            var jogosList = new JogosListViewModel();
            jogosList.Jogos = _jogoRepository.Jogos;
            jogosList.CategoriaAtual = "Categoria Atual";
            return View(jogosList);
        }
    }
}
