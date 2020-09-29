using Microsoft.EntityFrameworkCore.Migrations;

namespace FinPro.Web.Migrations
{
    public partial class AlterUserPasswordField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(36)",
                oldMaxLength: 36);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "varchar(36)",
                maxLength: 36,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 5000);
        }
    }
}
