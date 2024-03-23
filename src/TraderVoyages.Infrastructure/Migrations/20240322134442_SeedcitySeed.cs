using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TraderVoyages.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedcitySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CityGoods",
                columns: new[] { "CityGoodID", "CityID", "GoodID", "PurchasePrice", "SalePrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 20m, 25m },
                    { 2, 1, 2, 30m, 35m },
                    { 3, 1, 3, 25m, 30m },
                    { 4, 1, 4, 15m, 20m },
                    { 5, 2, 1, 22m, 27m },
                    { 6, 2, 2, 32m, 37m },
                    { 7, 2, 3, 27m, 32m },
                    { 8, 2, 4, 17m, 22m },
                    { 9, 3, 1, 24m, 29m },
                    { 10, 3, 2, 34m, 39m },
                    { 11, 3, 3, 29m, 34m },
                    { 12, 3, 4, 19m, 24m },
                    { 13, 4, 1, 26m, 31m },
                    { 14, 4, 2, 36m, 41m },
                    { 15, 4, 3, 31m, 36m },
                    { 16, 4, 4, 21m, 26m },
                    { 17, 5, 1, 28m, 33m },
                    { 18, 5, 2, 38m, 43m },
                    { 19, 5, 3, 33m, 38m },
                    { 20, 5, 4, 23m, 28m },
                    { 21, 6, 1, 30m, 35m },
                    { 22, 6, 2, 40m, 45m },
                    { 23, 6, 3, 35m, 40m },
                    { 24, 6, 4, 25m, 30m },
                    { 25, 7, 1, 32m, 37m },
                    { 26, 7, 2, 42m, 47m },
                    { 27, 7, 3, 37m, 42m },
                    { 28, 7, 4, 27m, 32m },
                    { 29, 8, 1, 34m, 39m },
                    { 30, 8, 2, 44m, 49m },
                    { 31, 8, 3, 39m, 44m },
                    { 32, 8, 4, 29m, 34m },
                    { 33, 9, 1, 36m, 41m },
                    { 34, 9, 2, 46m, 51m },
                    { 35, 9, 3, 41m, 46m },
                    { 36, 9, 4, 31m, 36m },
                    { 37, 10, 1, 38m, 43m },
                    { 38, 10, 2, 48m, 53m },
                    { 39, 10, 3, 43m, 48m },
                    { 40, 10, 4, 33m, 38m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CityGoods",
                keyColumn: "CityGoodID",
                keyValue: 40);
        }
    }
}
