using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CDMSystem.Repositorio.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActiveSkill",
                columns: table => new
                {
                    IdActiveSkill = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeActiveSkill = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    DescricaoActiveSkill = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveSkill", x => x.IdActiveSkill);
                });

            migrationBuilder.CreateTable(
                name: "Cube",
                columns: table => new
                {
                    IdCube = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    QuantidadeItemCube = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    StatusItemCube = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cube", x => x.IdCube);
                });

            migrationBuilder.CreateTable(
                name: "Guild",
                columns: table => new
                {
                    IdGuild = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeGuild = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    DescricaoGuild = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guild", x => x.IdGuild);
                });

            migrationBuilder.CreateTable(
                name: "Raca",
                columns: table => new
                {
                    IdRaca = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeRaca = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    BonusRaca = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    RaceSkillRaca = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raca", x => x.IdRaca);
                });

            migrationBuilder.CreateTable(
                name: "Secret",
                columns: table => new
                {
                    IdSecret = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeSecret = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    DescricaoSecret = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    TempoSecret = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    TempoEsperaSecret = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    BonusSecret = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    BonusAposSecret = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    AposSecret = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secret", x => x.IdSecret);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    IdItem = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdCubeItem = table.Column<int>(nullable: false),
                    NomeItem = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    DescricaoItem = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    RaridadeItem = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    RankItem = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    TipoItem = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    StatusItem = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    HpItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    MpItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DmgfItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DmgmItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DefItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    FurItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DetItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    CritItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    AcrItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    CubeIdCube = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.IdItem);
                    table.ForeignKey(
                        name: "FK_Item_Cube_CubeIdCube",
                        column: x => x.CubeIdCube,
                        principalTable: "Cube",
                        principalColumn: "IdCube",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Cube_IdCubeItem",
                        column: x => x.IdCubeItem,
                        principalTable: "Cube",
                        principalColumn: "IdCube",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classe",
                columns: table => new
                {
                    IdClasse = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdGuildClasse = table.Column<int>(nullable: false),
                    NomeClasse = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    StatusClasse = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    ArmaduraClasse = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    ArmaPrimariaClasse = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    ArmaSecundariaClasse = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    PenalidadeClasse = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    HabilidadePassivaClasse = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    HpClasse = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    MpClasse = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DmgfClasse = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DmgmClasse = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DefClasse = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    FurClasse = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DetClasse = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    CritClasse = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    AcrClasse = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    PericiaLaminasClasse = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
                    PericiaLongaDistanciaClasse = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
                    PericiaArremecoClasse = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
                    PericiaCorpoCorpoClasse = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classe", x => x.IdClasse);
                    table.ForeignKey(
                        name: "FK_Classe_Guild_IdGuildClasse",
                        column: x => x.IdGuildClasse,
                        principalTable: "Guild",
                        principalColumn: "IdGuild",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OminiSkill",
                columns: table => new
                {
                    IdOminiSkill = table.Column<int>(nullable: false),
                    IdClasseOminiSkill = table.Column<int>(nullable: false),
                    IdSecretOminiSkill = table.Column<int>(nullable: false),
                    IdItemOminiSkill = table.Column<int>(nullable: false),
                    NomeOminiSkill = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    TipoOminiSkill = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    ElementoOminiSkill = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    DescricaoOminiSkill = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    EfeitoOminiSkill = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    CustoOminiSkill = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    AreaOminiSkill = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    LevelOminiSkill = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    UsoOminiSkill = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    ClasseIdClasse = table.Column<int>(nullable: true),
                    SecretIdSecret = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OminiSkill", x => x.IdOminiSkill);
                    table.ForeignKey(
                        name: "FK_OminiSkill_Classe_ClasseIdClasse",
                        column: x => x.ClasseIdClasse,
                        principalTable: "Classe",
                        principalColumn: "IdClasse",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OminiSkill_Classe_IdClasseOminiSkill",
                        column: x => x.IdClasseOminiSkill,
                        principalTable: "Classe",
                        principalColumn: "IdClasse",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OminiSkill_Item_IdOminiSkill",
                        column: x => x.IdOminiSkill,
                        principalTable: "Item",
                        principalColumn: "IdItem",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OminiSkill_Secret_IdSecretOminiSkill",
                        column: x => x.IdSecretOminiSkill,
                        principalTable: "Secret",
                        principalColumn: "IdSecret",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OminiSkill_Secret_SecretIdSecret",
                        column: x => x.SecretIdSecret,
                        principalTable: "Secret",
                        principalColumn: "IdSecret",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personagem",
                columns: table => new
                {
                    IdPersonagem = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdRacaPersonagem = table.Column<int>(nullable: false),
                    IdSecretPersonagem = table.Column<int>(nullable: false),
                    IdClassePersonagem = table.Column<int>(nullable: false),
                    IdActiveSkillPersonagem = table.Column<int>(nullable: false),
                    IdCubePersonagem = table.Column<int>(nullable: false),
                    NomePersonagem = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    LevelPersonagem = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    ImagemPersonagem = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    MarkPersonagem = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    OspPersonagem = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    SpPersonagem = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    OrdemPersonagem = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    HpPersonagem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    MpPersonagem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DmgfPersonagem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DmgmPersonagem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DefPersonagem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    FurPersonagem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DetPersonagem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    CritPersonagem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    AcrPersonagem = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagem", x => x.IdPersonagem);
                    table.ForeignKey(
                        name: "FK_Personagem_ActiveSkill_IdActiveSkillPersonagem",
                        column: x => x.IdActiveSkillPersonagem,
                        principalTable: "ActiveSkill",
                        principalColumn: "IdActiveSkill",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personagem_Classe_IdClassePersonagem",
                        column: x => x.IdClassePersonagem,
                        principalTable: "Classe",
                        principalColumn: "IdClasse",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personagem_Cube_IdCubePersonagem",
                        column: x => x.IdCubePersonagem,
                        principalTable: "Cube",
                        principalColumn: "IdCube",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personagem_Raca_IdRacaPersonagem",
                        column: x => x.IdRacaPersonagem,
                        principalTable: "Raca",
                        principalColumn: "IdRaca",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personagem_Secret_IdSecretPersonagem",
                        column: x => x.IdSecretPersonagem,
                        principalTable: "Secret",
                        principalColumn: "IdSecret",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreRequisito",
                columns: table => new
                {
                    IdPreRequisito = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DescricaoPreRequisito = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    IdOminiSkillPreRequisito = table.Column<int>(nullable: false),
                    OminiSkillIdOminiSkill = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreRequisito", x => x.IdPreRequisito);
                    table.ForeignKey(
                        name: "FK_PreRequisito_OminiSkill_IdOminiSkillPreRequisito",
                        column: x => x.IdOminiSkillPreRequisito,
                        principalTable: "OminiSkill",
                        principalColumn: "IdOminiSkill",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreRequisito_OminiSkill_OminiSkillIdOminiSkill",
                        column: x => x.OminiSkillIdOminiSkill,
                        principalTable: "OminiSkill",
                        principalColumn: "IdOminiSkill",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classe_IdGuildClasse",
                table: "Classe",
                column: "IdGuildClasse");

            migrationBuilder.CreateIndex(
                name: "IX_Item_CubeIdCube",
                table: "Item",
                column: "CubeIdCube");

            migrationBuilder.CreateIndex(
                name: "IX_Item_IdCubeItem",
                table: "Item",
                column: "IdCubeItem");

            migrationBuilder.CreateIndex(
                name: "IX_OminiSkill_ClasseIdClasse",
                table: "OminiSkill",
                column: "ClasseIdClasse");

            migrationBuilder.CreateIndex(
                name: "IX_OminiSkill_IdClasseOminiSkill",
                table: "OminiSkill",
                column: "IdClasseOminiSkill");

            migrationBuilder.CreateIndex(
                name: "IX_OminiSkill_IdSecretOminiSkill",
                table: "OminiSkill",
                column: "IdSecretOminiSkill");

            migrationBuilder.CreateIndex(
                name: "IX_OminiSkill_SecretIdSecret",
                table: "OminiSkill",
                column: "SecretIdSecret");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_IdActiveSkillPersonagem",
                table: "Personagem",
                column: "IdActiveSkillPersonagem");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_IdClassePersonagem",
                table: "Personagem",
                column: "IdClassePersonagem");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_IdCubePersonagem",
                table: "Personagem",
                column: "IdCubePersonagem");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_IdRacaPersonagem",
                table: "Personagem",
                column: "IdRacaPersonagem");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_IdSecretPersonagem",
                table: "Personagem",
                column: "IdSecretPersonagem");

            migrationBuilder.CreateIndex(
                name: "IX_PreRequisito_IdOminiSkillPreRequisito",
                table: "PreRequisito",
                column: "IdOminiSkillPreRequisito");

            migrationBuilder.CreateIndex(
                name: "IX_PreRequisito_OminiSkillIdOminiSkill",
                table: "PreRequisito",
                column: "OminiSkillIdOminiSkill");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personagem");

            migrationBuilder.DropTable(
                name: "PreRequisito");

            migrationBuilder.DropTable(
                name: "ActiveSkill");

            migrationBuilder.DropTable(
                name: "Raca");

            migrationBuilder.DropTable(
                name: "OminiSkill");

            migrationBuilder.DropTable(
                name: "Classe");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Secret");

            migrationBuilder.DropTable(
                name: "Guild");

            migrationBuilder.DropTable(
                name: "Cube");
        }
    }
}
