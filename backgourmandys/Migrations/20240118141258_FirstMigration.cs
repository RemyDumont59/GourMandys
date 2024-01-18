using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backgourmandys.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Flavour",
                table: "Cakes");

            migrationBuilder.RenameColumn(
                name: "IsNumberOrLetterCake",
                table: "Cakes",
                newName: "IsNumberCake");

            migrationBuilder.AddColumn<bool>(
                name: "IsLetterCake",
                table: "Cakes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Flavors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flavors", x => x.Id);
                });

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

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsLetterCake",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsLetterCake",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsLetterCake",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsLetterCake", "IsNumberCake" },
                values: new object[] { false, false });

            migrationBuilder.CreateIndex(
                name: "IX_CakeFlavor_FlavorsId",
                table: "CakeFlavor",
                column: "FlavorsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CakeFlavor");

            migrationBuilder.DropTable(
                name: "Flavors");

            migrationBuilder.DropColumn(
                name: "IsLetterCake",
                table: "Cakes");

            migrationBuilder.RenameColumn(
                name: "IsNumberCake",
                table: "Cakes",
                newName: "IsNumberOrLetterCake");

            migrationBuilder.AddColumn<int>(
                name: "Flavour",
                table: "Cakes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Flavour",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Flavour",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Flavour",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Flavour", "IsNumberOrLetterCake" },
                values: new object[] { 9, true });
        }
    }
}
