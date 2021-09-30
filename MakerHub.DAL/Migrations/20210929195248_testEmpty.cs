using Microsoft.EntityFrameworkCore.Migrations;

namespace MakerHub.DAL.Migrations
{
    public partial class testEmpty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Humidity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Humidity = table.Column<float>(type: "REAL", nullable: false),
                    test = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Humidity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Intensity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Level = table.Column<string>(type: "TEXT", nullable: false),
                    Intensity = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intensity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Light",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Blue = table.Column<float>(type: "REAL", nullable: false),
                    Green = table.Column<float>(type: "REAL", nullable: false),
                    Red = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Light", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Temperature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Degrees = table.Column<float>(type: "REAL", nullable: false),
                    Farenheit = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temperature", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Humidity_Id",
                table: "Humidity",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Intensity_Id",
                table: "Intensity",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Light_Id",
                table: "Light",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Temperature_Id",
                table: "Temperature",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Humidity");

            migrationBuilder.DropTable(
                name: "Intensity");

            migrationBuilder.DropTable(
                name: "Light");

            migrationBuilder.DropTable(
                name: "Temperature");
        }
    }
}
