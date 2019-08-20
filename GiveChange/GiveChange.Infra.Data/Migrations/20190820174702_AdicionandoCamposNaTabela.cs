using Microsoft.EntityFrameworkCore.Migrations;

namespace GiveChange.Infra.Data.Migrations
{
    public partial class AdicionandoCamposNaTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Moeda001",
                table: "Trocos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Moeda005",
                table: "Trocos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Moeda010",
                table: "Trocos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Moeda050",
                table: "Trocos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nota10",
                table: "Trocos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nota100",
                table: "Trocos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nota20",
                table: "Trocos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nota50",
                table: "Trocos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Moeda001",
                table: "Trocos");

            migrationBuilder.DropColumn(
                name: "Moeda005",
                table: "Trocos");

            migrationBuilder.DropColumn(
                name: "Moeda010",
                table: "Trocos");

            migrationBuilder.DropColumn(
                name: "Moeda050",
                table: "Trocos");

            migrationBuilder.DropColumn(
                name: "Nota10",
                table: "Trocos");

            migrationBuilder.DropColumn(
                name: "Nota100",
                table: "Trocos");

            migrationBuilder.DropColumn(
                name: "Nota20",
                table: "Trocos");

            migrationBuilder.DropColumn(
                name: "Nota50",
                table: "Trocos");
        }
    }
}
