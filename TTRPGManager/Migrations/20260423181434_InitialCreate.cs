using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TTRPGManager.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseCreatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaxHitPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentHitPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    PassivePerception = table.Column<int>(type: "INTEGER", nullable: false),
                    InitiativeBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    CasterLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    UseManualAC = table.Column<bool>(type: "INTEGER", nullable: false),
                    ManualACValue = table.Column<int>(type: "INTEGER", nullable: false),
                    Strength = table.Column<int>(type: "INTEGER", nullable: false),
                    Dexterity = table.Column<int>(type: "INTEGER", nullable: false),
                    Constitution = table.Column<int>(type: "INTEGER", nullable: false),
                    Intelligence = table.Column<int>(type: "INTEGER", nullable: false),
                    Wisdom = table.Column<int>(type: "INTEGER", nullable: false),
                    Charisma = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Portrait = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    HitDice = table.Column<string>(type: "TEXT", nullable: false),
                    Race = table.Column<string>(type: "TEXT", nullable: false),
                    HasStrengthProficiency = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasDexterityProficiency = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasConstitutionProficiency = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasIntelligenceProficiency = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasWisdomProficiency = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasCharismaProficiency = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasShield = table.Column<bool>(type: "INTEGER", nullable: false),
                    ArmorType = table.Column<int>(type: "INTEGER", nullable: false),
                    MonsterType = table.Column<int>(type: "INTEGER", nullable: false),
                    Alignment = table.Column<int>(type: "INTEGER", nullable: false),
                    Size = table.Column<int>(type: "INTEGER", nullable: false),
                    ClassType = table.Column<int>(type: "INTEGER", nullable: false),
                    CastingStat = table.Column<int>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    ChallengeRating = table.Column<double>(type: "REAL", nullable: true),
                    Location = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseCreatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CreatureAbility",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DamageBonus = table.Column<int>(type: "INTEGER", nullable: true),
                    LegendaryActionCost = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DamageDice = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    DamageType = table.Column<int>(type: "INTEGER", nullable: true),
                    BaseCreatureId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureAbility", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatureAbility_BaseCreatures_BaseCreatureId",
                        column: x => x.BaseCreatureId,
                        principalTable: "BaseCreatures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CreatureSkill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OverrideBonus = table.Column<int>(type: "INTEGER", nullable: true),
                    Skill = table.Column<int>(type: "INTEGER", nullable: false),
                    Proficiency = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseCreatureId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatureSkill_BaseCreatures_BaseCreatureId",
                        column: x => x.BaseCreatureId,
                        principalTable: "BaseCreatures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DamageModifier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Modifier = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseCreatureId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageModifier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DamageModifier_BaseCreatures_BaseCreatureId",
                        column: x => x.BaseCreatureId,
                        principalTable: "BaseCreatures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Weight = table.Column<int>(type: "INTEGER", nullable: true),
                    ArmorClassValue = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Cost = table.Column<string>(type: "TEXT", nullable: true),
                    DamageDice = table.Column<string>(type: "TEXT", nullable: true),
                    IsMagical = table.Column<bool>(type: "INTEGER", nullable: false),
                    RequiresAttunement = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsFinesseWeapon = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEquipped = table.Column<bool>(type: "INTEGER", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Rarity = table.Column<int>(type: "INTEGER", nullable: false),
                    DamageType = table.Column<int>(type: "INTEGER", nullable: true),
                    ArmorType = table.Column<int>(type: "INTEGER", nullable: true),
                    BaseCreatureId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_BaseCreatures_BaseCreatureId",
                        column: x => x.BaseCreatureId,
                        principalTable: "BaseCreatures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MovementSpeed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Speed = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    AbleToHover = table.Column<bool>(type: "INTEGER", nullable: false),
                    BaseCreatureId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementSpeed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovementSpeed_BaseCreatures_BaseCreatureId",
                        column: x => x.BaseCreatureId,
                        principalTable: "BaseCreatures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CastingTime = table.Column<string>(type: "TEXT", nullable: false),
                    Range = table.Column<string>(type: "TEXT", nullable: false),
                    Duration = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Components = table.Column<string>(type: "TEXT", nullable: true),
                    School = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseCreatureId = table.Column<int>(type: "INTEGER", nullable: true)
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
                name: "IX_CreatureAbility_BaseCreatureId",
                table: "CreatureAbility",
                column: "BaseCreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureSkill_BaseCreatureId",
                table: "CreatureSkill",
                column: "BaseCreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_DamageModifier_BaseCreatureId",
                table: "DamageModifier",
                column: "BaseCreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_BaseCreatureId",
                table: "Items",
                column: "BaseCreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementSpeed_BaseCreatureId",
                table: "MovementSpeed",
                column: "BaseCreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_BaseCreatureId",
                table: "Spells",
                column: "BaseCreatureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreatureAbility");

            migrationBuilder.DropTable(
                name: "CreatureSkill");

            migrationBuilder.DropTable(
                name: "DamageModifier");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "MovementSpeed");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "BaseCreatures");
        }
    }
}
