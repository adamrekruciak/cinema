using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektBlazor.API.Migrations
{
    /// <inheritdoc />
    public partial class nowa1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Films");

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "Sale",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Sale",
                keyColumn: "Id",
                keyValue: 1,
                column: "FilmId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Sale",
                keyColumn: "Id",
                keyValue: 2,
                column: "FilmId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Sale",
                keyColumn: "Id",
                keyValue: 3,
                column: "FilmId",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "Sale");

            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Films",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5,
                column: "SalaId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Miejsca",
                columns: new[] { "Id", "Email", "Imie", "Nazwisko", "Numer", "Phone", "Rzad", "SalaId" },
                values: new object[] { 6, "", "", "", 6, "", 1, 2 });
        }
    }
}
