#nullable disable

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MudTestApp.Migrations
{
    public partial class Updated_ModelDataValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compound",
                columns: table => new
                {
                    CompoundID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompoundName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C_Hardness = table.Column<int>(type: "int", nullable: false),
                    C_25Mod = table.Column<int>(type: "int", nullable: false),
                    C_50Mod = table.Column<int>(type: "int", nullable: false),
                    C_100Mod = table.Column<int>(type: "int", nullable: false),
                    C_Tensile = table.Column<int>(type: "int", nullable: false),
                    C_Elongation = table.Column<int>(type: "int", nullable: false),
                    C_Production = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compound", x => x.CompoundID);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    TestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabTechAssigned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MudType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MudSystemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExposureTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateStarted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestComments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.TestID);
                });

            migrationBuilder.CreateTable(
                name: "TestResults",
                columns: table => new
                {
                    TestResultsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestID = table.Column<int>(type: "int", nullable: false),
                    CompoundID = table.Column<int>(type: "int", nullable: false),
                    TestTemp = table.Column<int>(type: "int", nullable: false),
                    S1Thickness = table.Column<double>(type: "float", nullable: false),
                    S1Hardness_a = table.Column<double>(type: "float", nullable: false),
                    S1Hardness_b = table.Column<double>(type: "float", nullable: false),
                    S1WtAir_a = table.Column<double>(type: "float", nullable: false),
                    S1WtAir_b = table.Column<double>(type: "float", nullable: false),
                    S1WtWater_a = table.Column<double>(type: "float", nullable: false),
                    S1WtWater_b = table.Column<double>(type: "float", nullable: false),
                    S1_25Mod = table.Column<int>(type: "int", nullable: false),
                    S1_50Mod = table.Column<int>(type: "int", nullable: false),
                    S1_100Mod = table.Column<int>(type: "int", nullable: false),
                    S1_tensile = table.Column<int>(type: "int", nullable: false),
                    S1_elongation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestResults", x => x.TestResultsID);
                    table.ForeignKey(
                        name: "FK_TestResults_Compound_CompoundID",
                        column: x => x.CompoundID,
                        principalTable: "Compound",
                        principalColumn: "CompoundID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestResults_Test_TestID",
                        column: x => x.TestID,
                        principalTable: "Test",
                        principalColumn: "TestID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_CompoundID",
                table: "TestResults",
                column: "CompoundID");

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_TestID",
                table: "TestResults",
                column: "TestID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestResults");

            migrationBuilder.DropTable(
                name: "Compound");

            migrationBuilder.DropTable(
                name: "Test");
        }
    }
}
