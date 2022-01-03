using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CBoardings.Data.Migrations
{
    public partial class alteredBoardingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EW",
                table: "Boardings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NS",
                table: "Boardings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EW",
                table: "Boardings");

            migrationBuilder.DropColumn(
                name: "NS",
                table: "Boardings");
        }
    }
}
