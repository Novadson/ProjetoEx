using Microsoft.EntityFrameworkCore.Migrations;

namespace StockControl.Migrations
{
    public partial class EnderecoForne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Fornecedor",
                newName: "Uf");

            migrationBuilder.RenameColumn(
                name: "Endereco",
                table: "Fornecedor",
                newName: "Rua");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Fornecedor",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Fornecedor",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Fornecedor",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "Fornecedor");

            migrationBuilder.RenameColumn(
                name: "Uf",
                table: "Fornecedor",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "Rua",
                table: "Fornecedor",
                newName: "Endereco");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
