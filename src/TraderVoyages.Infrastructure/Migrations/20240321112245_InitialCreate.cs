using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraderVoyages.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    TotalCount = table.Column<int>(type: "int", nullable: false)
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
                    Money = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    CityGoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    GoodID = table.Column<int>(type: "int", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityGoods", x => x.CityGoodID);
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

            migrationBuilder.CreateIndex(
                name: "IX_CityGoods_CityID",
                table: "CityGoods",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_CityGoods_GoodID",
                table: "CityGoods",
                column: "GoodID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityGoods");

            migrationBuilder.DropTable(
                name: "MountTypes");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Goods");
        }
    }
}
