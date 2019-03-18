using Microsoft.EntityFrameworkCore.Migrations;

namespace StockControl.Migrations
{
    public partial class VendaFun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeVendedor",
                table: "Venda");

            migrationBuilder.AddColumn<int>(
                name: "FuncionarioId",
                table: "Venda",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venda_FuncionarioId",
                table: "Venda",
                column: "FuncionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Funcionario_FuncionarioId",
                table: "Venda",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Funcionario_FuncionarioId",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_FuncionarioId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Venda");

            migrationBuilder.AddColumn<string>(
                name: "NomeVendedor",
                table: "Venda",
                nullable: true);
        }
    }
}
