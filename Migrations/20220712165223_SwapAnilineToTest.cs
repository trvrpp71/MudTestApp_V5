using Microsoft.EntityFrameworkCore.Migrations;

namespace MudTestApp.Migrations
{
    public partial class SwapAnilineToTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnilinePoint",
                table: "TestResults");

            migrationBuilder.AddColumn<double>(
                name: "AnilinePoint",
                table: "Test",
                type: "float",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnilinePoint",
                table: "Test");

            migrationBuilder.AddColumn<double>(
                name: "AnilinePoint",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
