using Microsoft.EntityFrameworkCore.Migrations;

namespace MudTestApp.Migrations
{
    public partial class computedCol_test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "HardnessChange",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Hardness_After_Avg",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Hardness_Before_Avg",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HardnessChange",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "Hardness_After_Avg",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "Hardness_Before_Avg",
                table: "TestResults");
        }
    }
}
