using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektBlazor.API.Migrations
{
    /// <inheritdoc />
    public partial class NoweImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "/Img/TokioDrift1.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "/Img/HarryPotter1.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "/Img/PulpFiction1.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "/Img/It1.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "/Img/TokioDrift.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "/Img/HarryPotter.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "/Img/PulpFiction.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "/Img/It.jpg");
        }
    }
}
