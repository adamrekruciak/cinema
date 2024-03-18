using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektBlazor.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MiejsceID",
                table: "Sale");

            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Miejsca",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 1,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 2,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 3,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 4,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 5,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 6,
                column: "SalaId",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Miejsca");

            migrationBuilder.AddColumn<int>(
                name: "MiejsceID",
                table: "Sale",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Sale",
                keyColumn: "Id",
                keyValue: 1,
                column: "MiejsceID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Sale",
                keyColumn: "Id",
                keyValue: 2,
                column: "MiejsceID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Sale",
                keyColumn: "Id",
                keyValue: 3,
                column: "MiejsceID",
                value: 3);
        }
    }
}
