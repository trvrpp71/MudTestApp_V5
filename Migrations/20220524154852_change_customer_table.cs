using Microsoft.EntityFrameworkCore.Migrations;

namespace MudTestApp.Migrations
{
    public partial class change_customer_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactName",
                table: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "ContactName",
                table: "Test",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactName",
                table: "Test");

            migrationBuilder.AddColumn<string>(
                name: "ContactName",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
