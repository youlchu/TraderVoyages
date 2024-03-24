using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TraderVoyages.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class StartDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XCoordinate = table.Column<int>(type: "int", nullable: false),
                    YCoordinate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    GoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.GoodID);
                });

            migrationBuilder.CreateTable(
                name: "MountTypes",
                columns: table => new
                {
                    MountTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarryCapacity = table.Column<int>(type: "int", nullable: false),
                    StepCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MountTypes", x => x.MountTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Money = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    XCoordinate = table.Column<int>(type: "int", nullable: false),
                    YCoordinate = table.Column<int>(type: "int", nullable: false),
                    CurrentCityID = table.Column<int>(type: "int", nullable: false),
                    MountTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerID);
                });

            migrationBuilder.CreateTable(
                name: "CityGoods",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false),
                    GoodID = table.Column<int>(type: "int", nullable: false),
                    CityGoodID = table.Column<int>(type: "int", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityGoods", x => new { x.CityID, x.GoodID });
                    table.ForeignKey(
                        name: "FK_CityGoods_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityGoods_Goods_GoodID",
                        column: x => x.GoodID,
                        principalTable: "Goods",
                        principalColumn: "GoodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Player1Id = table.Column<int>(type: "int", nullable: false),
                    Player2Id = table.Column<int>(type: "int", nullable: false),
                    TurnId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Players_Player1Id",
                        column: x => x.Player1Id,
                        principalTable: "Players",
                        principalColumn: "PlayerID");
                    table.ForeignKey(
                        name: "FK_Games_Players_Player2Id",
                        column: x => x.Player2Id,
                        principalTable: "Players",
                        principalColumn: "PlayerID");
                });

            migrationBuilder.CreateTable(
                name: "PlayerGood",
                columns: table => new
                {
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    GoodID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerGood", x => new { x.PlayerID, x.GoodID });
                    table.ForeignKey(
                        name: "FK_PlayerGood_Goods_GoodID",
                        column: x => x.GoodID,
                        principalTable: "Goods",
                        principalColumn: "GoodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerGood_Players_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Players",
                        principalColumn: "PlayerID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "GoodID", "Name", "Weight" },
                values: new object[,]
                {
                    { 1, "Wheat", 3 },
                    { 2, "Spice", 7 },
                    { 3, "Cotton", 5 },
                    { 4, "Copper", 2 }
                });

            migrationBuilder.InsertData(
                table: "MountTypes",
                columns: new[] { "MountTypeID", "CarryCapacity", "Name", "StepCapacity" },
                values: new object[,]
                {
                    { 1, 100, "Horse", 60 },
                    { 2, 150, "Camel", 40 },
                    { 3, 300, "Elephant", 20 }
                });

            migrationBuilder.InsertData(
                table: "CityGoods",
                columns: new[] { "CityID", "GoodID", "CityGoodID", "PurchasePrice", "Quantity", "SalePrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 20m, 188, 25m },
                    { 1, 2, 2, 30m, 159, 35m },
                    { 1, 3, 3, 25m, 122, 30m },
                    { 1, 4, 4, 15m, 156, 20m },
                    { 2, 1, 5, 22m, 143, 27m },
                    { 2, 2, 6, 32m, 168, 37m },
                    { 2, 3, 7, 27m, 115, 32m },
                    { 2, 4, 8, 17m, 115, 22m },
                    { 3, 1, 9, 24m, 147, 29m },
                    { 3, 2, 10, 34m, 117, 39m },
                    { 3, 3, 11, 29m, 193, 34m },
                    { 3, 4, 12, 19m, 109, 24m },
                    { 4, 1, 13, 26m, 182, 31m },
                    { 4, 2, 14, 36m, 142, 41m },
                    { 4, 3, 15, 31m, 136, 36m },
                    { 4, 4, 16, 21m, 176, 26m },
                    { 5, 1, 17, 28m, 138, 33m },
                    { 5, 2, 18, 38m, 149, 43m },
                    { 5, 3, 19, 33m, 103, 38m },
                    { 5, 4, 20, 23m, 128, 28m },
                    { 6, 1, 21, 30m, 180, 35m },
                    { 6, 2, 22, 40m, 166, 45m },
                    { 6, 3, 23, 35m, 163, 40m },
                    { 6, 4, 24, 25m, 160, 30m },
                    { 7, 1, 25, 32m, 152, 37m },
                    { 7, 2, 26, 42m, 199, 47m },
                    { 7, 3, 27, 37m, 113, 42m },
                    { 7, 4, 28, 27m, 197, 32m },
                    { 8, 1, 29, 34m, 121, 39m },
                    { 8, 2, 30, 44m, 178, 49m },
                    { 8, 3, 31, 39m, 140, 44m },
                    { 8, 4, 32, 29m, 112, 34m },
                    { 9, 1, 33, 36m, 181, 41m },
                    { 9, 2, 34, 46m, 114, 51m },
                    { 9, 3, 35, 41m, 154, 46m },
                    { 9, 4, 36, 31m, 131, 36m },
                    { 10, 1, 37, 38m, 139, 43m },
                    { 10, 2, 38, 48m, 194, 53m },
                    { 10, 3, 39, 43m, 152, 48m },
                    { 10, 4, 40, 33m, 139, 38m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CityGoods_GoodID",
                table: "CityGoods",
                column: "GoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Player1Id",
                table: "Games",
                column: "Player1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Player2Id",
                table: "Games",
                column: "Player2Id");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGood_GoodID",
                table: "PlayerGood",
                column: "GoodID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityGoods");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "MountTypes");

            migrationBuilder.DropTable(
                name: "PlayerGood");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
