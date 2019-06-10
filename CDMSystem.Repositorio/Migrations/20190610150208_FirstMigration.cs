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
                name: "Core",
                columns: table => new
                {
                    IdCore = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeCore = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    DescricaoCore = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    TipoCore = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    HpCore = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    MpCore = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DmgfCore = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DmgmCore = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DefCore = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    FurCore = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DetCore = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    CritCore = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    AcrCore = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core", x => x.IdCore);
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
                    IdItem = table.Column<int>(nullable: false),
                    IdCubeItem = table.Column<int>(nullable: false),
                    NomeItem = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    DescricaoItem = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    RaridadeItem = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    RankItem = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false),
                    TipoItem = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    HpItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    MpItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DmgfItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DmgmItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DefItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    FurItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    DetItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    CritItem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    AcrItem = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.IdItem);
                    table.ForeignKey(
                        name: "FK_Item_Cube_IdItem",
                        column: x => x.IdItem,
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
                    IdGuildClasse = table.Column<string>(nullable: true),
                    GuildClasseIdGuild = table.Column<int>(nullable: true),
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
                        name: "FK_Classe_Guild_GuildClasseIdGuild",
                        column: x => x.GuildClasseIdGuild,
                        principalTable: "Guild",
                        principalColumn: "IdGuild",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OminiSkill",
                columns: table => new
                {
                    IdOminiSkill = table.Column<int>(nullable: false),
                    IdClasseOminiSkill = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    IdSecretOminiSkill = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    IdItemOminiSkill = table.Column<int>(nullable: false),
                    NomeOminiSkill = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    TipoOminiSkill = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    ElementoOminiSkill = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    DescricaoOminiSkill = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    EfeitoOminiSkill = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    CustoOminiSkill = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    AreaOminiSkill = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    LevelOminiSkill = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    UsoOminiSkill = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OminiSkill", x => x.IdOminiSkill);
                    table.ForeignKey(
                        name: "FK_OminiSkill_Classe_IdOminiSkill",
                        column: x => x.IdOminiSkill,
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
                        name: "FK_OminiSkill_Secret_IdOminiSkill",
                        column: x => x.IdOminiSkill,
                        principalTable: "Secret",
                        principalColumn: "IdSecret",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personagem",
                columns: table => new
                {
                    IdPersonagem = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdRacaPersonagem = table.Column<string>(nullable: true),
                    RacaPersonagemIdRaca = table.Column<int>(nullable: true),
                    IdSecretPersonagem = table.Column<string>(nullable: true),
                    SecretPersonagemIdSecret = table.Column<int>(nullable: true),
                    IdClassePersonagem = table.Column<string>(nullable: true),
                    ClassePersonagemIdClasse = table.Column<int>(nullable: true),
                    IdActiveSkillPersonagem = table.Column<string>(nullable: true),
                    ActiveSkillPersonagemIdActiveSkill = table.Column<int>(nullable: true),
                    IdCubePersonagem = table.Column<string>(nullable: true),
                    CubePersonagemIdCube = table.Column<int>(nullable: true),
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
                    AcrPersonagem = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    ElmoPersonagemIdCore = table.Column<int>(nullable: true),
                    PeitoralPersonagemIdCore = table.Column<int>(nullable: true),
                    BracoDireitoPersonagemIdCore = table.Column<int>(nullable: true),
                    BracoEsquerdoPersonagemIdCore = table.Column<int>(nullable: true),
                    CalcaPersonagemIdCore = table.Column<int>(nullable: true),
                    BotaPersonagemIdCore = table.Column<int>(nullable: true),
                    ArmaPrimariaPersonagemIdCore = table.Column<int>(nullable: true),
                    ArmaSecundariaPersonagemIdCore = table.Column<int>(nullable: true),
                    PendantePersonagemIdCore = table.Column<int>(nullable: true),
                    AnelDireitoPersonagemIdCore = table.Column<int>(nullable: true),
                    AnelEsquerdoPersonagemIdCore = table.Column<int>(nullable: true),
                    AsaPersonagemIdCore = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagem", x => x.IdPersonagem);
                    table.ForeignKey(
                        name: "FK_Personagem_ActiveSkill_ActiveSkillPersonagemIdActiveSkill",
                        column: x => x.ActiveSkillPersonagemIdActiveSkill,
                        principalTable: "ActiveSkill",
                        principalColumn: "IdActiveSkill",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personagem_Core_AnelDireitoPersonagemIdCore",
                        column: x => x.AnelDireitoPersonagemIdCore,
                        principalTable: "Core",
                        principalColumn: "IdCore",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personagem_Core_AnelEsquerdoPersonagemIdCore",
                        column: x => x.AnelEsquerdoPersonagemIdCore,
                        principalTable: "Core",
                        principalColumn: "IdCore",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personagem_Core_ArmaPrimariaPersonagemIdCore",
                        column: x => x.ArmaPrimariaPersonagemIdCore,
                        principalTable: "Core",
                        principalColumn: "IdCore",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personagem_Core_ArmaSecundariaPersonagemIdCore",
                        column: x => x.ArmaSecundariaPersonagemIdCore,
                        principalTable: "Core",
                        principalColumn: "IdCore",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personagem_Core_AsaPersonagemIdCore",
                        column: x => x.AsaPersonagemIdCore,
                        principalTable: "Core",
                        principalColumn: "IdCore",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personagem_Core_BotaPersonagemIdCore",
                        column: x => x.BotaPersonagemIdCore,
                        principalTable: "Core",
                        principalColumn: "IdCore",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personagem_Core_BracoDireitoPersonagemIdCore",
                        column: x => x.BracoDireitoPersonagemIdCore,
                        principalTable: "Core",
                        principalColumn: "IdCore",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personagem_Core_BracoEsquerdoPersonagemIdCore",
                        column: x => x.BracoEsquerdoPersonagemIdCore,
                        principalTable: "Core",
                        principalColumn: "IdCore",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personagem_Core_CalcaPersonagemIdCore",
                        column: x => x.CalcaPersonagemIdCore,
                        principalTable: "Core",
                        principalColumn: "IdCore",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personagem_Classe_ClassePersonagemIdClasse",
                        column: x => x.ClassePersonagemIdClasse,
                        principalTable: "Classe",
                        principalColumn: "IdClasse",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personagem_Cube_CubePersonagemIdCube",
                        column: x => x.CubePersonagemIdCube,
                        principalTable: "Cube",
                        principalColumn: "IdCube",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personagem_Core_ElmoPersonagemIdCore",
                        column: x => x.ElmoPersonagemIdCore,
                        principalTable: "Core",
                        principalColumn: "IdCore",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personagem_Core_PeitoralPersonagemIdCore",
                        column: x => x.PeitoralPersonagemIdCore,
                        principalTable: "Core",
                        principalColumn: "IdCore",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personagem_Core_PendantePersonagemIdCore",
                        column: x => x.PendantePersonagemIdCore,
                        principalTable: "Core",
                        principalColumn: "IdCore",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personagem_Raca_RacaPersonagemIdRaca",
                        column: x => x.RacaPersonagemIdRaca,
                        principalTable: "Raca",
                        principalColumn: "IdRaca",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personagem_Secret_SecretPersonagemIdSecret",
                        column: x => x.SecretPersonagemIdSecret,
                        principalTable: "Secret",
                        principalColumn: "IdSecret",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreRequisito",
                columns: table => new
                {
                    IdPreRequisito = table.Column<int>(nullable: false),
                    DescricaoPreRequisito = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreRequisito", x => x.IdPreRequisito);
                    table.ForeignKey(
                        name: "FK_PreRequisito_OminiSkill_IdPreRequisito",
                        column: x => x.IdPreRequisito,
                        principalTable: "OminiSkill",
                        principalColumn: "IdOminiSkill",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classe_GuildClasseIdGuild",
                table: "Classe",
                column: "GuildClasseIdGuild");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_ActiveSkillPersonagemIdActiveSkill",
                table: "Personagem",
                column: "ActiveSkillPersonagemIdActiveSkill");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_AnelDireitoPersonagemIdCore",
                table: "Personagem",
                column: "AnelDireitoPersonagemIdCore");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_AnelEsquerdoPersonagemIdCore",
                table: "Personagem",
                column: "AnelEsquerdoPersonagemIdCore");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_ArmaPrimariaPersonagemIdCore",
                table: "Personagem",
                column: "ArmaPrimariaPersonagemIdCore");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_ArmaSecundariaPersonagemIdCore",
                table: "Personagem",
                column: "ArmaSecundariaPersonagemIdCore");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_AsaPersonagemIdCore",
                table: "Personagem",
                column: "AsaPersonagemIdCore");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_BotaPersonagemIdCore",
                table: "Personagem",
                column: "BotaPersonagemIdCore");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_BracoDireitoPersonagemIdCore",
                table: "Personagem",
                column: "BracoDireitoPersonagemIdCore");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_BracoEsquerdoPersonagemIdCore",
                table: "Personagem",
                column: "BracoEsquerdoPersonagemIdCore");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_CalcaPersonagemIdCore",
                table: "Personagem",
                column: "CalcaPersonagemIdCore");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_ClassePersonagemIdClasse",
                table: "Personagem",
                column: "ClassePersonagemIdClasse");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_CubePersonagemIdCube",
                table: "Personagem",
                column: "CubePersonagemIdCube");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_ElmoPersonagemIdCore",
                table: "Personagem",
                column: "ElmoPersonagemIdCore");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_PeitoralPersonagemIdCore",
                table: "Personagem",
                column: "PeitoralPersonagemIdCore");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_PendantePersonagemIdCore",
                table: "Personagem",
                column: "PendantePersonagemIdCore");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_RacaPersonagemIdRaca",
                table: "Personagem",
                column: "RacaPersonagemIdRaca");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_SecretPersonagemIdSecret",
                table: "Personagem",
                column: "SecretPersonagemIdSecret");
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
                name: "Core");

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
