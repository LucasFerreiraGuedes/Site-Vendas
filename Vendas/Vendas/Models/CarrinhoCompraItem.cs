using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendas.Models
{
	public class CarrinhoCompraItem
	{
	
		public int CarrinhoCompraItemId { get; set; }

		public Jogo Jogo { get; set; }

		public int Quantidade { get; set; }

		[StringLength(200)]
		public string CarrinhoCompraId { get; set; }
	}
}
