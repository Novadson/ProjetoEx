using Microsoft.EntityFrameworkCore.Migrations;

namespace StockControl.Migrations
{
    public partial class GrauEscolaridade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GrauInstrucao",
                table: "Funcionario",
                newName: "GrauEscolaridade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GrauEscolaridade",
                table: "Funcionario",
                newName: "GrauInstrucao");
        }
    }
}
