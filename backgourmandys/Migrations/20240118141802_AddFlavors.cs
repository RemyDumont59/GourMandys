using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backgourmandys.Migrations
{
    /// <inheritdoc />
    public partial class AddFlavors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Flavors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Chocolat" },
                    { 2, "Bueno" },
                    { 3, "Framboise" },
                    { 4, "Fraise" },
                    { 5, "Poire" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
