using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjektBlazor.API.Migrations
{
    /// <inheritdoc />
    public partial class okrojona : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hours");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.RenameColumn(
                name: "SalaId",
                table: "Miejsca",
                newName: "FilmId");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Dlugosc", "ImageURL", "Nazwa", "Produkcja", "Wiek", "ZwiastunURL" },
                values: new object[] { "130 min", "/Img/HarryPotter.jpg", "Harry Potter i Insygnia Śmierci: Część II / Napisy", "USA | 2011", 16, "https://www.youtube.com/watch?v=mObK5XD8udk&ab_channel=WarnerBros.Pictures" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Dlugosc", "ImageURL", "Nazwa", "Produkcja", "Wiek", "ZwiastunURL" },
                values: new object[] { "154 min", "/Img/PulpFiction.jpg", "Pulp Fiction / Napisy", "USA | 1994", 18, "https://www.youtube.com/watch?v=s7EdQ4FqbhY&ab_channel=Movieclips" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Dlugosc", "ImageURL", "Nazwa", "Produkcja", "Wiek", "ZwiastunURL" },
                values: new object[] { "135 min", "/Img/It.jpg", "It / Napisy", "USA | 2017", 16, "https://www.youtube.com/watch?v=FnCdOQsX5kc&ab_channel=WarnerBros.Pictures" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FilmId",
                table: "Miejsca",
                newName: "SalaId");

            migrationBuilder.CreateTable(
                name: "Hours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    Godzina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LiczbaMiejsc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Dlugosc", "ImageURL", "Nazwa", "Produkcja", "Wiek", "ZwiastunURL" },
                values: new object[] { "178 min", "/Img/WladcaPierscieni.jpg", "Władca pierścieni: Drużyna pierścienia / Napisy", "USA | 2001", 6, "https://www.youtube.com/watch?v=V75dMMIW2B4&ab_channel=Movieclips" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Dlugosc", "ImageURL", "Nazwa", "Produkcja", "Wiek", "ZwiastunURL" },
                values: new object[] { "182 min", "/Img/EndGame.jpg", "Avengers: Endgame / Napisy", "USA | 2019", 12, "https://www.youtube.com/watch?v=TcMBFSGVi1c&ab_channel=MarvelEntertainment" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Dlugosc", "ImageURL", "Nazwa", "Produkcja", "Wiek", "ZwiastunURL" },
                values: new object[] { "182 min", "/Img/EndGame.jpg", "Avengers: Endgame / Dubbing", "USA | 2019", 12, "https://www.youtube.com/watch?v=TcMBFSGVi1c&ab_channel=MarvelEntertainment" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Dlugosc", "ImageURL", "Nazwa", "Produkcja", "Wiek", "ZwiastunURL" },
                values: new object[,]
                {
                    { 5, "130 min", "/Img/HarryPotter.jpg", "Harry Potter i Insygnia Śmierci: Część II / Napisy", "USA | 2011", 16, "https://www.youtube.com/watch?v=mObK5XD8udk&ab_channel=WarnerBros.Pictures" },
                    { 6, "154 min", "/Img/PulpFiction.jpg", "Pulp Fiction / Napisy", "USA | 1994", 18, "https://www.youtube.com/watch?v=s7EdQ4FqbhY&ab_channel=Movieclips" },
                    { 7, "135 min", "/Img/It.jpg", "It / Napisy", "USA | 2017", 16, "https://www.youtube.com/watch?v=FnCdOQsX5kc&ab_channel=WarnerBros.Pictures" }
                });

            migrationBuilder.InsertData(
                table: "Hours",
                columns: new[] { "Id", "FilmId", "Godzina", "SalaId" },
                values: new object[,]
                {
                    { 1, 1, "12:00", 1 },
                    { 2, 1, "15:25", 1 },
                    { 3, 2, "19:10", 1 },
                    { 4, 2, "12:35", 2 },
                    { 5, 3, "15:40", 2 },
                    { 6, 3, "19:35", 2 },
                    { 7, 4, "12:50", 3 },
                    { 8, 5, "16:05", 3 },
                    { 9, 6, "20:30", 4 },
                    { 10, 6, "12:45", 4 },
                    { 11, 7, "17:20", 4 }
                });

            migrationBuilder.InsertData(
                table: "Sale",
                columns: new[] { "Id", "LiczbaMiejsc" },
                values: new object[,]
                {
                    { 1, 168 },
                    { 2, 168 },
                    { 3, 120 },
                    { 4, 120 }
                });
        }
    }
}
