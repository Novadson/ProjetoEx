using Microsoft.EntityFrameworkCore.Migrations;

namespace StockControl.Migrations
{
    public partial class statusString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Fornecedor",
                nullable: false,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Fornecedor",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
