using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MudTestApp.Migrations
{
    public partial class removed_time : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeOut",
                table: "Test");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TimeOut",
                table: "Test",
                type: "datetime2",
                nullable: true);
        }
    }
}
