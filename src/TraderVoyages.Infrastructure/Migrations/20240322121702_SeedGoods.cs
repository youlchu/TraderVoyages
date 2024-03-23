using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TraderVoyages.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedGoods : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Goods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "GoodID", "Name", "TotalCount", "Weight" },
                values: new object[,]
                {
                    { 1, "Wheat", 400, 3 },
                    { 2, "Spice", 500, 7 },
                    { 3, "Cotton", 700, 5 },
                    { 4, "Copper", 400, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "GoodID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "GoodID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "GoodID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "GoodID",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Goods");
        }
    }
}
