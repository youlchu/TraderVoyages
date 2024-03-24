using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraderVoyages.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusToGame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 1, 1 },
                column: "Quantity",
                value: 147);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 1, 2 },
                column: "Quantity",
                value: 143);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 1, 3 },
                column: "Quantity",
                value: 141);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 1, 4 },
                column: "Quantity",
                value: 153);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 2, 2 },
                column: "Quantity",
                value: 148);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 2, 3 },
                column: "Quantity",
                value: 183);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 2, 4 },
                column: "Quantity",
                value: 125);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 3, 1 },
                column: "Quantity",
                value: 115);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 3, 2 },
                column: "Quantity",
                value: 160);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 3, 3 },
                column: "Quantity",
                value: 179);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 3, 4 },
                column: "Quantity",
                value: 198);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 4, 1 },
                column: "Quantity",
                value: 171);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 4, 2 },
                column: "Quantity",
                value: 111);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 4, 3 },
                column: "Quantity",
                value: 160);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 4, 4 },
                column: "Quantity",
                value: 151);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 5, 1 },
                column: "Quantity",
                value: 155);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 5, 2 },
                column: "Quantity",
                value: 108);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 5, 3 },
                column: "Quantity",
                value: 104);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 5, 4 },
                column: "Quantity",
                value: 104);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 6, 1 },
                column: "Quantity",
                value: 110);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 6, 2 },
                column: "Quantity",
                value: 104);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 6, 3 },
                column: "Quantity",
                value: 200);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 6, 4 },
                column: "Quantity",
                value: 196);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 7, 1 },
                column: "Quantity",
                value: 137);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 7, 2 },
                column: "Quantity",
                value: 149);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 7, 3 },
                column: "Quantity",
                value: 156);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 7, 4 },
                column: "Quantity",
                value: 113);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 8, 1 },
                column: "Quantity",
                value: 147);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 8, 2 },
                column: "Quantity",
                value: 133);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 8, 3 },
                column: "Quantity",
                value: 106);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 8, 4 },
                column: "Quantity",
                value: 171);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 9, 1 },
                column: "Quantity",
                value: 174);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 9, 2 },
                column: "Quantity",
                value: 171);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 9, 3 },
                column: "Quantity",
                value: 158);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 9, 4 },
                column: "Quantity",
                value: 155);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 10, 1 },
                column: "Quantity",
                value: 180);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 10, 2 },
                column: "Quantity",
                value: 190);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 10, 3 },
                column: "Quantity",
                value: 101);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 10, 4 },
                column: "Quantity",
                value: 111);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Games");

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 1, 1 },
                column: "Quantity",
                value: 188);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 1, 2 },
                column: "Quantity",
                value: 159);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 1, 3 },
                column: "Quantity",
                value: 122);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 1, 4 },
                column: "Quantity",
                value: 156);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 2, 2 },
                column: "Quantity",
                value: 168);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 2, 3 },
                column: "Quantity",
                value: 115);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 2, 4 },
                column: "Quantity",
                value: 115);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 3, 1 },
                column: "Quantity",
                value: 147);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 3, 2 },
                column: "Quantity",
                value: 117);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 3, 3 },
                column: "Quantity",
                value: 193);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 3, 4 },
                column: "Quantity",
                value: 109);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 4, 1 },
                column: "Quantity",
                value: 182);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 4, 2 },
                column: "Quantity",
                value: 142);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 4, 3 },
                column: "Quantity",
                value: 136);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 4, 4 },
                column: "Quantity",
                value: 176);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 5, 1 },
                column: "Quantity",
                value: 138);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 5, 2 },
                column: "Quantity",
                value: 149);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 5, 3 },
                column: "Quantity",
                value: 103);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 5, 4 },
                column: "Quantity",
                value: 128);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 6, 1 },
                column: "Quantity",
                value: 180);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 6, 2 },
                column: "Quantity",
                value: 166);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 6, 3 },
                column: "Quantity",
                value: 163);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 6, 4 },
                column: "Quantity",
                value: 160);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 7, 1 },
                column: "Quantity",
                value: 152);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 7, 2 },
                column: "Quantity",
                value: 199);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 7, 3 },
                column: "Quantity",
                value: 113);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 7, 4 },
                column: "Quantity",
                value: 197);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 8, 1 },
                column: "Quantity",
                value: 121);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 8, 2 },
                column: "Quantity",
                value: 178);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 8, 3 },
                column: "Quantity",
                value: 140);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 8, 4 },
                column: "Quantity",
                value: 112);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 9, 1 },
                column: "Quantity",
                value: 181);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 9, 2 },
                column: "Quantity",
                value: 114);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 9, 3 },
                column: "Quantity",
                value: 154);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 9, 4 },
                column: "Quantity",
                value: 131);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 10, 1 },
                column: "Quantity",
                value: 139);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 10, 2 },
                column: "Quantity",
                value: 194);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 10, 3 },
                column: "Quantity",
                value: 152);

            migrationBuilder.UpdateData(
                table: "CityGoods",
                keyColumns: new[] { "CityID", "GoodID" },
                keyValues: new object[] { 10, 4 },
                column: "Quantity",
                value: 139);
        }
    }
}
