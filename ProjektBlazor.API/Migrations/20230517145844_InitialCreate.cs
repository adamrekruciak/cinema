using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjektBlazor.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data_filmu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dlugosc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Miejsca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numer = table.Column<int>(type: "int", nullable: false),
                    Rzad = table.Column<int>(type: "int", nullable: false),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Miejsca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LiczbaMiejsc = table.Column<int>(type: "int", nullable: false),
                    MiejsceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Data_filmu", "Dlugosc", "Nazwa", "SalaId" },
                values: new object[,]
                {
                    { 1, "9:00 22.08.2023", "168min", "Kot w butach", 1 },
                    { 2, "9:00 22.08.2023", "168min", "Kot w butach 2", 1 },
                    { 3, "9:00 22.08.2023", "168min", "Kot w butach 3", 1 },
                    { 4, "9:00 22.08.2023", "168min", "Kot w butach 4", 1 },
                    { 5, "9:00 22.08.2023", "168min", "Kot w butach 5", 1 }
                });

            migrationBuilder.InsertData(
                table: "Miejsca",
                columns: new[] { "Id", "Email", "Imie", "Nazwisko", "Numer", "Phone", "Rzad" },
                values: new object[,]
                {
                    { 1, "", "", "", 1, "", 1 },
                    { 2, "", "", "", 2, "", 1 },
                    { 3, "", "", "", 3, "", 1 },
                    { 4, "", "", "", 4, "", 1 },
                    { 5, "", "", "", 5, "", 1 },
                    { 6, "", "", "", 6, "", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sale",
                columns: new[] { "Id", "LiczbaMiejsc", "MiejsceID" },
                values: new object[,]
                {
                    { 1, 40, 1 },
                    { 2, 52, 2 },
                    { 3, 46, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Miejsca");

            migrationBuilder.DropTable(
                name: "Sale");
        }
    }
}
