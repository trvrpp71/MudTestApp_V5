using Microsoft.EntityFrameworkCore.Migrations;

namespace MudTestApp.Migrations
{
    public partial class Add_Epicor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Epicor",
                table: "Test",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Epicor",
                table: "Test");
        }
    }
}
