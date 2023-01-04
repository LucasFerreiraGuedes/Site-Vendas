using Vendas.Models;

namespace Vendas.ViewModels
{
	public class JogosListViewModel
	{
		public IEnumerable<Jogo> Jogos { get; set; }

		public string CategoriaAtual { get; set; }
	}
}
