using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backgourmandys.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PicturePaths",
                columns: new[] { "Id", "CakeId", "Path" },
                values: new object[,]
                {
                    { 3, 2, "https://www.pieceofcake.gi/wp-content/uploads/2020/11/IMG_2918.jpg" },
                    { 4, 2, "https://simshomekitchen.com/wp-content/uploads/2022/08/kinder-cake-2.png" },
                    { 5, 3, "https://lafrenchiepatisserie.com/wp-content/uploads/2021/07/WhatsApp-Image-2021-07-05-at-18.34.09-1.jpeg" },
                    { 6, 3, "https://lafrenchiepatisserie.com/wp-content/uploads/2021/07/WhatsApp-Image-2021-07-05-at-23.11.41.jpeg" },
                    { 7, 4, "https://i.etsystatic.com/18089847/r/il/1eddf2/1669714698/il_1080xN.1669714698_khkj.jpg" },
                    { 8, 4, "https://i.ebayimg.com/images/g/K1AAAOSwfn9gcN1L/s-l1600.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PicturePaths",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
