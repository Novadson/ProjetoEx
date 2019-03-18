﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace StockControl.Migrations
{
    public partial class remoSucesa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sucess",
                table: "Fornecedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "sucess",
                table: "Fornecedor",
                nullable: false,
                defaultValue: false);
        }
    }
}
