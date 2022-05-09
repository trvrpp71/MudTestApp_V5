using Microsoft.EntityFrameworkCore.Migrations;

namespace MudTestApp.Migrations
{
    public partial class DB_addVariablesToResults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "S2Hardness_a",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "S2Hardness_b",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "S2Thickness",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "S2WtAir_a",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "S2WtAir_b",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "S2WtWater_a",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "S2WtWater_b",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "S2_100Mod",
                table: "TestResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "S2_25Mod",
                table: "TestResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "S2_50Mod",
                table: "TestResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "S2_elongation",
                table: "TestResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "S2_tensile",
                table: "TestResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "S3Hardness_a",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "S3Hardness_b",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "S3Thickness",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "S3WtAir_a",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "S3WtAir_b",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "S3WtWater_a",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "S3WtWater_b",
                table: "TestResults",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "S3_100Mod",
                table: "TestResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "S3_25Mod",
                table: "TestResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "S3_50Mod",
                table: "TestResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "S3_elongation",
                table: "TestResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "S3_tensile",
                table: "TestResults",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "S2Hardness_a",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S2Hardness_b",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S2Thickness",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S2WtAir_a",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S2WtAir_b",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S2WtWater_a",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S2WtWater_b",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S2_100Mod",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S2_25Mod",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S2_50Mod",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S2_elongation",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S2_tensile",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S3Hardness_a",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S3Hardness_b",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S3Thickness",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S3WtAir_a",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S3WtAir_b",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S3WtWater_a",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S3WtWater_b",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S3_100Mod",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S3_25Mod",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S3_50Mod",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S3_elongation",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "S3_tensile",
                table: "TestResults");
        }
    }
}
