using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendas.Migrations
{
    public partial class PopulandoJogos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Jogos (Nome,DescricaoCurta,DescricaoDetalhada,Preco,JogoPreferido,EmEstoque,CategoriaId) " +
                "VALUES ('Mortal Kombat 21','Mortal Kombat 11 é um jogo eletrônico de combate em que dois jogadores lutam um contra o outro ou contra uma inteligência artificia.','Mortal Kombat 11 é um jogo eletrônico de combate em que dois jogadores lutam um contra o outro ou contra uma inteligência .',199.99,0,'1',1)");
            migrationBuilder.Sql("INSERT INTO Jogos (Nome,DescricaoCurta,DescricaoDetalhada,Preco,JogoPreferido,EmEstoque,CategoriaId) " +
                "VALUES ('Mortal Kombat 21','Mortal Kombat 11 é um jogo eletrônico de combate em que dois jogadores lutam um contra o outro ou contra uma inteligência artificial nu','Mortal Kombat 11 é um jogo eletrônico de combate em que dois jogadores lutam um contra o outro ou contra uma inteligência artificial.',199.99,0,'1',2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Jogos");
        }
    }
}
