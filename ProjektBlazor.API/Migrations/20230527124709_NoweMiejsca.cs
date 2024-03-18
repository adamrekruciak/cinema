using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektBlazor.API.Migrations
{
    /// <inheritdoc />
    public partial class NoweMiejsca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "mmgz@wp.pl", "Marek", "Gryzoń", "+49123456789" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "jk@gmail.com", "Jan", "Kowalski", "+49512212123" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "jk@gmail.com", "Jan", "Kowalski", "+49512212123" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "jk@gmail.com", "Jan", "Kowalski", "+49512212123" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "jk@gmail.com", "Jan", "Kowalski", "+49512212123" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "jk@gmail.com", "Jan", "Kowalski", "+49512212123" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "gn@wp.pl", "Grzegorz", "Nowak", "+49123456789" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "annak@wp.pl", "Anna", "Kowalczyk", "+49123456789" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "annak@wp.pl", "Anna", "Kowalczyk", "+49123456789" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "annak@wp.pl", "Anna", "Kowalczyk", "+49123456789" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "annak@wp.pl", "Anna", "Kowalczyk", "+49123456789" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "annak@wp.pl", "Anna", "Kowalczyk", "+49123456789" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "annak@wp.pl", "Anna", "Kowalczyk", "+49123456789" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "annak@wp.pl", "Anna", "Kowalczyk", "+49123456789" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "annak@wp.pl", "Anna", "Kowalczyk", "+49123456789" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Miejsca",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Email", "Imie", "Nazwisko", "Phone" },
                values: new object[] { "", "", "", "" });
        }
    }
}
