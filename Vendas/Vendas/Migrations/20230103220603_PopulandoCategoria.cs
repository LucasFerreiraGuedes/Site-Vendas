using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendas.Migrations
{
    public partial class PopulandoCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO CATEGORIAS (CategoriaNome,Descricao) Values ('XBOX ONE','Jogos para a Plataforma Xbox One console criado pela Microsoft')");
            migrationBuilder.Sql("INSERT INTO CATEGORIAS (CategoriaNome,Descricao) Values ('PS4','Jogos para a Plataforma Playstation, console criado pela Sony')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM CATEGORIAS"); 
        }
    }
}
