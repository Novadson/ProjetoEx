using Microsoft.EntityFrameworkCore.Migrations;

namespace StockControl.Migrations
{
    public partial class CMV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EstoqueInicial",
                table: "Produto",
                newName: "QtdEmEstoque");

            migrationBuilder.AddColumn<decimal>(
                name: "CMV",
                table: "Produto",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "EstoqueMinimo",
                table: "Produto",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CMV",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "EstoqueMinimo",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "QtdEmEstoque",
                table: "Produto",
                newName: "EstoqueInicial");
        }
    }
}
