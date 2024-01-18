using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backgourmandys.Migrations
{
    /// <inheritdoc />
    public partial class TableCakeFlavorv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CakeFlavors",
                columns: new[] { "CakeId", "FlavorId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 2, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CakeFlavors",
                keyColumns: new[] { "CakeId", "FlavorId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CakeFlavors",
                keyColumns: new[] { "CakeId", "FlavorId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CakeFlavors",
                keyColumns: new[] { "CakeId", "FlavorId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CakeFlavors",
                keyColumns: new[] { "CakeId", "FlavorId" },
                keyValues: new object[] { 2, 3 });
        }
    }
}
