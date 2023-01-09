using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendas.Migrations
{
    public partial class PopulandoJogosPreferidos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql("INSERT INTO Jogos (Nome,DescricaoCurta,DescricaoDetalhada,Preco,JogoPreferido,EmEstoque,CategoriaId) " +
				"VALUES ('Mario Kart','Mortal Kombat 11 é um jogo eletrônico de combate em que dois jogadores lutam um contra o outro ou contra uma inteligência artificia.','A diferença desse jogo para os demais jogos de corrida é a possibilidade de usar utensílios e atalhos para vencer a corrida.',199.99,1,'1',1)");
		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
