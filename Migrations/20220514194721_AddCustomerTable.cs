using Microsoft.EntityFrameworkCore.Migrations;

namespace MudTestApp.Migrations
{
    public partial class AddCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerID",
                table: "Test",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID1",
                table: "Test",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Test_CustomerID1",
                table: "Test",
                column: "CustomerID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Test_Customer_CustomerID1",
                table: "Test",
                column: "CustomerID1",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Test_Customer_CustomerID1",
                table: "Test");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Test_CustomerID1",
                table: "Test");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Test");

            migrationBuilder.DropColumn(
                name: "CustomerID1",
                table: "Test");
        }
    }
}
