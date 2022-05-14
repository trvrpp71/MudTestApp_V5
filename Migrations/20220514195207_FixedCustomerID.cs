using Microsoft.EntityFrameworkCore.Migrations;

namespace MudTestApp.Migrations
{
    public partial class FixedCustomerID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Test_Customer_CustomerID1",
                table: "Test");

            migrationBuilder.DropIndex(
                name: "IX_Test_CustomerID1",
                table: "Test");

            migrationBuilder.DropColumn(
                name: "CustomerID1",
                table: "Test");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Test",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Test_CustomerID",
                table: "Test",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Test_Customer_CustomerID",
                table: "Test",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Test_Customer_CustomerID",
                table: "Test");

            migrationBuilder.DropIndex(
                name: "IX_Test_CustomerID",
                table: "Test");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "Test",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID1",
                table: "Test",
                type: "int",
                nullable: true);

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
    }
}
