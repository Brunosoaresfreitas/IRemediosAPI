using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IRemedios.API.Migrations
{
    public partial class Updating1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PostedAt",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostedAt",
                table: "Medicines");
        }
    }
}
