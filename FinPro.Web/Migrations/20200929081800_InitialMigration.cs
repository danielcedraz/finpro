using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace FinPro.Web.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    UF = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.UF);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    Password = table.Column<string>(maxLength: 36, nullable: false),
                    CPF = table.Column<long>(maxLength: 11, nullable: false),
                    CompanyName = table.Column<string>(maxLength: 100, nullable: false),
                    CNPJ = table.Column<long>(maxLength: 14, nullable: false),
                    CEP = table.Column<int>(maxLength: 8, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: false),
                    AddressNumber = table.Column<string>(maxLength: 10, nullable: false),
                    AddressComplement = table.Column<string>(maxLength: 100, nullable: true),
                    AddressState = table.Column<string>(nullable: false),
                    AddressCity = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_State_AddressState",
                        column: x => x.AddressState,
                        principalTable: "State",
                        principalColumn: "UF",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Budget",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Customer = table.Column<int>(nullable: false),
                    DataHora = table.Column<DateTime>(nullable: false),
                    FullStackAmount = table.Column<int>(nullable: false),
                    DesignerAmount = table.Column<int>(nullable: false),
                    ScrumMasterAmount = table.Column<int>(nullable: false),
                    ProjectOwnerAmount = table.Column<int>(nullable: false),
                    DurationDays = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budget", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Budget_User_Customer",
                        column: x => x.Customer,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "UF", "Name" },
                values: new object[,]
                {
                    { "AC", "Acre" },
                    { "SP", "São Paulo" },
                    { "SC", "Santa Catarina" },
                    { "RR", "Roraima" },
                    { "RO", "Rondônia" },
                    { "RS", "Rio Grande do Sul" },
                    { "RN", "Rio Grande do Norte" },
                    { "RJ", "Rio de Janeiro" },
                    { "PI", "Piauí" },
                    { "PE", "Pernambuco" },
                    { "PR", "Paraná" },
                    { "PB", "Paraíba" },
                    { "SE", "Sergipe" },
                    { "PA", "Pará" },
                    { "MS", "Mato Grosso do Sul" },
                    { "MT", "Mato Grosso" },
                    { "MA", "Maranhão" },
                    { "GO", "Coiás" },
                    { "ES", "Espírito Santo" },
                    { "DF", "Distrito Federal" },
                    { "CE", "Ceará" },
                    { "BA", "Bahia" },
                    { "AM", "Amazonas" },
                    { "AP", "Amapá" },
                    { "AL", "Alagoas" },
                    { "MG", "Minas Gerais" },
                    { "TO", "Tocantins" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Budget_Customer",
                table: "Budget",
                column: "Customer");

            migrationBuilder.CreateIndex(
                name: "IX_User_AddressState",
                table: "User",
                column: "AddressState");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Budget");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "State");
        }
    }
}
