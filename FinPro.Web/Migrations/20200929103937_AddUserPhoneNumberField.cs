using Microsoft.EntityFrameworkCore.Migrations;

namespace FinPro.Web.Migrations
{
    public partial class AddUserPhoneNumberField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PhoneNumber",
                table: "User",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "User");
        }
    }
}
