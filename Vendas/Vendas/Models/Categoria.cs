using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendas.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = " Favor informar um nome para a Categoria")]
        [StringLength(100,ErrorMessage ="Respeite o tamanho maximo da Categoria 100 caracteres")]
        [Display(Name = "Nome da Categoria")]
        public string CategoriaNome { get; set; }

        [Required(ErrorMessage = "Favor informar a descrição da Categoria")]
        [StringLength(200,ErrorMessage = " O tamanho máximo da descrição é 200 caracteres")]
        [Display(Name = "nome")]
        public string Descricao { get; set; }

        public List<Jogo> Jogos { get; set; }
    }
}
