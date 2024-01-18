using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backgourmandys.Migrations
{
    /// <inheritdoc />
    public partial class TableCakeFlavor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CakeFlavor");

            migrationBuilder.CreateTable(
                name: "CakeFlavors",
                columns: table => new
                {
                    CakeId = table.Column<int>(type: "int", nullable: false),
                    FlavorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CakeFlavors", x => new { x.CakeId, x.FlavorId });
                    table.ForeignKey(
                        name: "FK_CakeFlavors_Cakes_CakeId",
                        column: x => x.CakeId,
                        principalTable: "Cakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CakeFlavors_Flavors_FlavorId",
                        column: x => x.FlavorId,
                        principalTable: "Flavors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CakeFlavors_FlavorId",
                table: "CakeFlavors",
                column: "FlavorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CakeFlavors");

            migrationBuilder.CreateTable(
                name: "CakeFlavor",
                columns: table => new
                {
                    CakesId = table.Column<int>(type: "int", nullable: false),
                    FlavorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CakeFlavor", x => new { x.CakesId, x.FlavorsId });
                    table.ForeignKey(
                        name: "FK_CakeFlavor_Cakes_CakesId",
                        column: x => x.CakesId,
                        principalTable: "Cakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CakeFlavor_Flavors_FlavorsId",
                        column: x => x.FlavorsId,
                        principalTable: "Flavors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CakeFlavor_FlavorsId",
                table: "CakeFlavor",
                column: "FlavorsId");
        }
    }
}
