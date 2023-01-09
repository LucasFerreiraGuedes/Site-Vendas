using Microsoft.AspNetCore.Mvc;
using Vendas.Models;
using Vendas.Repository.Interfaces;
using Vendas.ViewModels;

namespace Vendas.Controllers
{
	public class CarrinhoCompraController : Controller
	{

		private readonly IJogosRepository _jogoRepository;
		private readonly CarrinhoCompra _carrinhoCompra;

		public CarrinhoCompraController(IJogosRepository jogoRepository, CarrinhoCompra carrinhoCompra)
		{
			_jogoRepository = jogoRepository;
			_carrinhoCompra = carrinhoCompra;
		}

		public IActionResult Index()
		{
			var itens = _carrinhoCompra.GetCarrinhoCompraItens();
			_carrinhoCompra.CarrinhoCompraItems = itens;

			var carrinhoCompraVM = new CarrinhoCompraViewModel
			{
				CarrinhoCompra = _carrinhoCompra,
				CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
			};

			return View(carrinhoCompraVM);
		}


		public IActionResult AdicionarItemNoCarrinhoCompra(int jogoId)
		{
			var jogoSelecionado = _jogoRepository.Jogos.FirstOrDefault(p => p.Jogoid== jogoId);

			if (jogoSelecionado != null)
			{
				_carrinhoCompra.AdicionarAoCarrinho(jogoSelecionado);	
			}
			return RedirectToAction("Index");
		}

		public IActionResult RemoverItemDoCarrinhoCompra(int jogoId)
		{
			var jogoSelecionado = _jogoRepository.Jogos.FirstOrDefault(p => p.Jogoid == jogoId);

			if (jogoSelecionado != null)
			{
				_carrinhoCompra.RemoverDoCarrinho(jogoSelecionado);
			}
			return RedirectToAction("Index");
		}



	}
}
