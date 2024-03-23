using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TraderVoyages.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMountTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MountTypes",
                columns: new[] { "MountTypeID", "CarryCapacity", "Name", "StepCapacity" },
                values: new object[,]
                {
                    { 1, 100, "Horse", 60 },
                    { 2, 150, "Camel", 40 },
                    { 3, 300, "Elephant", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MountTypes",
                keyColumn: "MountTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MountTypes",
                keyColumn: "MountTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MountTypes",
                keyColumn: "MountTypeID",
                keyValue: 3);
        }
    }
}
