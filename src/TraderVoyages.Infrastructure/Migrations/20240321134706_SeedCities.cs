using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TraderVoyages.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedCities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "Name", "XCoordinate", "YCoordinate" },
                values: new object[,]
                {
                    { 1, "Quixotica", 10, 20 },
                    { 2, "Avalonia", 30, 40 },
                    { 3, "Eldorado", 50, 60 },
                    { 4, "Atlantis", 70, 80 },
                    { 5, "Shangri-La", 90, 100 },
                    { 6, "Xanadu", 110, 120 },
                    { 7, "Narnia", 130, 140 },
                    { 8, "Hogwarts", 150, 160 },
                    { 9, "Neverland", 170, 180 },
                    { 10, "Gotham", 190, 200 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 10);
        }
    }
}
