using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinPro.Web.Migrations
{
    public partial class AddBudgetValueField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataHora",
                table: "Budget");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Budget",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Value",
                table: "Budget",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Budget");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Budget");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataHora",
                table: "Budget",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
