using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vendas.Migrations
{
    public partial class CarrinhoCompraItens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarrinhoCompraItens",
                columns: table => new
                {
                    CarrinhoCompraItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jogoid = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CarrinhoCompraId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoCompraItens", x => x.CarrinhoCompraItemId);
                    table.ForeignKey(
                        name: "FK_CarrinhoCompraItens_Jogos_Jogoid",
                        column: x => x.Jogoid,
                        principalTable: "Jogos",
                        principalColumn: "Jogoid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoCompraItens_Jogoid",
                table: "CarrinhoCompraItens",
                column: "Jogoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoCompraItens");
        }
    }
}
