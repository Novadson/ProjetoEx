using Microsoft.EntityFrameworkCore.Migrations;

namespace StockControl.Migrations
{
    public partial class numero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Complemento",
                table: "Cliente",
                newName: "Numero");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Cliente",
                newName: "Complemento");
        }
    }
}
