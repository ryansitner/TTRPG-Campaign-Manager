using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TTRPGManager.Migrations
{
    /// <inheritdoc />
    public partial class RefineItemBlueprint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "IsEquipped",
                table: "Items");

            migrationBuilder.AlterColumn<double>(
                name: "Weight",
                table: "Items",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CostInCopper",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Items",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MaxRange",
                table: "Items",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NormalRange",
                table: "Items",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostInCopper",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "MaxRange",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "NormalRange",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "Items",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cost",
                table: "Items",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsEquipped",
                table: "Items",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
