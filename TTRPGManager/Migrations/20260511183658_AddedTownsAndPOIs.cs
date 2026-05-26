using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TTRPGManager.Migrations
{
    /// <inheritdoc />
    public partial class AddedTownsAndPOIs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "POIId",
                table: "BaseCreatures",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TownId",
                table: "BaseCreatures",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MapId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    DMNotes = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Towns_Maps_MapId",
                        column: x => x.MapId,
                        principalTable: "Maps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "POIs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TownId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    POIType = table.Column<string>(type: "TEXT", nullable: false),
                    DMNotes = table.Column<string>(type: "TEXT", nullable: true),
                    IsStore = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POIs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_POIs_Towns_TownId",
                        column: x => x.TownId,
                        principalTable: "Towns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseCreatures_POIId",
                table: "BaseCreatures",
                column: "POIId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseCreatures_TownId",
                table: "BaseCreatures",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_POIs_TownId",
                table: "POIs",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_Towns_MapId",
                table: "Towns",
                column: "MapId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseCreatures_POIs_POIId",
                table: "BaseCreatures",
                column: "POIId",
                principalTable: "POIs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseCreatures_Towns_TownId",
                table: "BaseCreatures",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseCreatures_POIs_POIId",
                table: "BaseCreatures");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseCreatures_Towns_TownId",
                table: "BaseCreatures");

            migrationBuilder.DropTable(
                name: "POIs");

            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DropIndex(
                name: "IX_BaseCreatures_POIId",
                table: "BaseCreatures");

            migrationBuilder.DropIndex(
                name: "IX_BaseCreatures_TownId",
                table: "BaseCreatures");

            migrationBuilder.DropColumn(
                name: "POIId",
                table: "BaseCreatures");

            migrationBuilder.DropColumn(
                name: "TownId",
                table: "BaseCreatures");
        }
    }
}
