using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendas.Models
{
    [Table("Jogos")]
    public class Jogo
    {
        [Key]
        public int Jogoid { get; set; }

        [Required(ErrorMessage = "Favor informar um nome para o Jogo")]
        [StringLength(80,MinimumLength = 5,ErrorMessage = "Mínimo de caracteres é 5 e o máximo é 80")]
        [Display(Name = "Nome do Jogo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Favor informar uma descrição curta para o Jogo")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Mínimo de caracteres é 5 e o máximo é 200")]
        [Display(Name = "Descrição Curta do Jogo")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "Favor informar uma descrição detalhada para o Jogo")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Mínimo de caracteres é 5 e o máximo é 200")]
        [Display(Name = "Descrição Detalhada do Jogo")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Favor informaro preço do Jogo")]
        [Column(TypeName = "decimal(10,2)")]
        [Display(Name = "Preço do Jogo")]
        [Range(1,999.99,ErrorMessage = "O preço do jogo deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho da imagem Maior")]
        [StringLength(300)]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho da imagem menor")]
        [StringLength(300)]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool JogoPreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
