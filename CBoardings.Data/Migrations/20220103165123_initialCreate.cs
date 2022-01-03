using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CBoardings.Data.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boardings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LatDeg = table.Column<int>(type: "int", nullable: false),
                    LatMin = table.Column<int>(type: "int", nullable: false),
                    LongDeg = table.Column<int>(type: "int", nullable: false),
                    LongMin = table.Column<int>(type: "int", nullable: false),
                    BoardingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsArrested = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boardings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boardings");
        }
    }
}
