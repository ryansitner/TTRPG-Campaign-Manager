using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TTRPGManager.Migrations
{
    /// <inheritdoc />
    public partial class AddedMagicAndSpellSlots : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreatureAbility_BaseCreatures_BaseCreatureId",
                table: "CreatureAbility");

            migrationBuilder.DropForeignKey(
                name: "FK_DamageModifier_BaseCreatures_BaseCreatureId",
                table: "DamageModifier");

            migrationBuilder.DropForeignKey(
                name: "FK_MovementSpeed_BaseCreatures_BaseCreatureId",
                table: "MovementSpeed");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.RenameColumn(
                name: "DamageBonus",
                table: "CreatureAbility",
                newName: "MiscDamageBonus");

            migrationBuilder.AlterColumn<int>(
                name: "BaseCreatureId",
                table: "MovementSpeed",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BaseCreatureId",
                table: "DamageModifier",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BaseCreatureId",
                table: "CreatureAbility",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AbilityStatType",
                table: "CreatureAbility",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpellSlotsLevel1",
                table: "BaseCreatures",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpellSlotsLevel2",
                table: "BaseCreatures",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpellSlotsLevel3",
                table: "BaseCreatures",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpellSlotsLevel4",
                table: "BaseCreatures",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpellSlotsLevel5",
                table: "BaseCreatures",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpellSlotsLevel6",
                table: "BaseCreatures",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpellSlotsLevel7",
                table: "BaseCreatures",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpellSlotsLevel8",
                table: "BaseCreatures",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpellSlotsLevel9",
                table: "BaseCreatures",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ConditionImmunity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BaseCreatureId = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionImmunity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConditionImmunity_BaseCreatures_BaseCreatureId",
                        column: x => x.BaseCreatureId,
                        principalTable: "BaseCreatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BaseCreatureId = table.Column<int>(type: "INTEGER", nullable: false),
                    SelectedLanguage = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomLanguage = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureLanguage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatureLanguage_BaseCreatures_BaseCreatureId",
                        column: x => x.BaseCreatureId,
                        principalTable: "BaseCreatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureSpells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BaseCreatureId = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DamageDice = table.Column<string>(type: "TEXT", nullable: true),
                    CastingTime = table.Column<string>(type: "TEXT", nullable: false),
                    Range = table.Column<string>(type: "TEXT", nullable: false),
                    Duration = table.Column<string>(type: "TEXT", nullable: false),
                    Components = table.Column<string>(type: "TEXT", nullable: true),
                    IsConcentration = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsCantrip = table.Column<bool>(type: "INTEGER", nullable: false),
                    School = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureSpells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatureSpells_BaseCreatures_BaseCreatureId",
                        column: x => x.BaseCreatureId,
                        principalTable: "BaseCreatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureTrait",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BaseCreatureId = table.Column<int>(type: "INTEGER", nullable: false),
                    TraitName = table.Column<string>(type: "TEXT", nullable: false),
                    TraitDescription = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureTrait", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatureTrait_BaseCreatures_BaseCreatureId",
                        column: x => x.BaseCreatureId,
                        principalTable: "BaseCreatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConditionImmunity_BaseCreatureId",
                table: "ConditionImmunity",
                column: "BaseCreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureLanguage_BaseCreatureId",
                table: "CreatureLanguage",
                column: "BaseCreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureSpells_BaseCreatureId",
                table: "CreatureSpells",
                column: "BaseCreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureTrait_BaseCreatureId",
                table: "CreatureTrait",
                column: "BaseCreatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureAbility_BaseCreatures_BaseCreatureId",
                table: "CreatureAbility",
                column: "BaseCreatureId",
                principalTable: "BaseCreatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DamageModifier_BaseCreatures_BaseCreatureId",
                table: "DamageModifier",
                column: "BaseCreatureId",
                principalTable: "BaseCreatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovementSpeed_BaseCreatures_BaseCreatureId",
                table: "MovementSpeed",
                column: "BaseCreatureId",
                principalTable: "BaseCreatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreatureAbility_BaseCreatures_BaseCreatureId",
                table: "CreatureAbility");

            migrationBuilder.DropForeignKey(
                name: "FK_DamageModifier_BaseCreatures_BaseCreatureId",
                table: "DamageModifier");

            migrationBuilder.DropForeignKey(
                name: "FK_MovementSpeed_BaseCreatures_BaseCreatureId",
                table: "MovementSpeed");

            migrationBuilder.DropTable(
                name: "ConditionImmunity");

            migrationBuilder.DropTable(
                name: "CreatureLanguage");

            migrationBuilder.DropTable(
                name: "CreatureSpells");

            migrationBuilder.DropTable(
                name: "CreatureTrait");

            migrationBuilder.DropColumn(
                name: "AbilityStatType",
                table: "CreatureAbility");

            migrationBuilder.DropColumn(
                name: "SpellSlotsLevel1",
                table: "BaseCreatures");

            migrationBuilder.DropColumn(
                name: "SpellSlotsLevel2",
                table: "BaseCreatures");

            migrationBuilder.DropColumn(
                name: "SpellSlotsLevel3",
                table: "BaseCreatures");

            migrationBuilder.DropColumn(
                name: "SpellSlotsLevel4",
                table: "BaseCreatures");

            migrationBuilder.DropColumn(
                name: "SpellSlotsLevel5",
                table: "BaseCreatures");

            migrationBuilder.DropColumn(
                name: "SpellSlotsLevel6",
                table: "BaseCreatures");

            migrationBuilder.DropColumn(
                name: "SpellSlotsLevel7",
                table: "BaseCreatures");

            migrationBuilder.DropColumn(
                name: "SpellSlotsLevel8",
                table: "BaseCreatures");

            migrationBuilder.DropColumn(
                name: "SpellSlotsLevel9",
                table: "BaseCreatures");

            migrationBuilder.RenameColumn(
                name: "MiscDamageBonus",
                table: "CreatureAbility",
                newName: "DamageBonus");

            migrationBuilder.AlterColumn<int>(
                name: "BaseCreatureId",
                table: "MovementSpeed",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "BaseCreatureId",
                table: "DamageModifier",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "BaseCreatureId",
                table: "CreatureAbility",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BaseCreatureId = table.Column<int>(type: "INTEGER", nullable: true),
                    CastingTime = table.Column<string>(type: "TEXT", nullable: false),
                    Components = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Duration = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Range = table.Column<string>(type: "TEXT", nullable: false),
                    School = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spells_BaseCreatures_BaseCreatureId",
                        column: x => x.BaseCreatureId,
                        principalTable: "BaseCreatures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Spells_BaseCreatureId",
                table: "Spells",
                column: "BaseCreatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureAbility_BaseCreatures_BaseCreatureId",
                table: "CreatureAbility",
                column: "BaseCreatureId",
                principalTable: "BaseCreatures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DamageModifier_BaseCreatures_BaseCreatureId",
                table: "DamageModifier",
                column: "BaseCreatureId",
                principalTable: "BaseCreatures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovementSpeed_BaseCreatures_BaseCreatureId",
                table: "MovementSpeed",
                column: "BaseCreatureId",
                principalTable: "BaseCreatures",
                principalColumn: "Id");
        }
    }
}
