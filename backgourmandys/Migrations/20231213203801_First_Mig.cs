using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backgourmandys.Migrations
{
    /// <inheritdoc />
    public partial class First_Mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Flavour = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pieces = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimalQuantity = table.Column<int>(type: "int", nullable: false),
                    Lot = table.Column<int>(type: "int", nullable: false),
                    IsNumberOrLetterCake = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cakes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PicturePaths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CakeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PicturePaths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PicturePaths_Cakes_CakeId",
                        column: x => x.CakeId,
                        principalTable: "Cakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "Id", "Category", "Content", "Flavour", "IsNumberOrLetterCake", "Lot", "MinimalQuantity", "Pieces", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 1, 3, "C'est un gâteau aux chocolats qui n'est bon !", 0, false, 1, 1, 1, 20.00m, "A4", "ChocoBon" },
                    { 2, 2, "C'est un biscuit aux chocolats Blancs qui n'est pas noir !", 17, false, 6, 4, 2, 10.00m, "A3", "KinderBuenoWhite" },
                    { 3, 0, "C'est un gâteau pour des mariages !", 16, false, 1, 1, 1, 200.00m, "A4", "MarryMe" },
                    { 4, 1, "C'est un gâteau d'anniversaire chocolats poire !", 9, true, 3, 10, 10, 15.99m, "A2", "HappyBirthDay" }
                });

            migrationBuilder.InsertData(
                table: "PicturePaths",
                columns: new[] { "Id", "CakeId", "Path" },
                values: new object[,]
                {
                    { 1, 1, "https://cdn.chefclub.tools/uploads/community/attachments/images/1e005648-4aa9-4a25-9695-31a65c37f37c_eQFrPBa.jpg" },
                    { 2, 1, "https://img-global.cpcdn.com/recipes/6ea0238b091c23d4/1200x630cq70/photo.jpg" },
                    { 3, 2, "https://www.pieceofcake.gi/wp-content/uploads/2020/11/IMG_2918.jpg" },
                    { 4, 2, "https://simshomekitchen.com/wp-content/uploads/2022/08/kinder-cake-2.png" },
                    { 5, 3, "https://lafrenchiepatisserie.com/wp-content/uploads/2021/07/WhatsApp-Image-2021-07-05-at-18.34.09-1.jpeg" },
                    { 6, 3, "https://lafrenchiepatisserie.com/wp-content/uploads/2021/07/WhatsApp-Image-2021-07-05-at-23.11.41.jpeg" },
                    { 7, 4, "https://i.etsystatic.com/18089847/r/il/1eddf2/1669714698/il_1080xN.1669714698_khkj.jpg" },
                    { 8, 4, "https://i.ebayimg.com/images/g/K1AAAOSwfn9gcN1L/s-l1600.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PicturePaths_CakeId",
                table: "PicturePaths",
                column: "CakeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PicturePaths");

            migrationBuilder.DropTable(
                name: "Cakes");
        }
    }
}
