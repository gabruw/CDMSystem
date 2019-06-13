﻿// <auto-generated />
using System;
using CDMSystem.Repositorio.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CDMSystem.Repositorio.Migrations
{
    [DbContext(typeof(CDMSystemContext))]
    partial class CDMSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CDMSystem.Dominio.DTO.ActiveSkill", b =>
                {
                    b.Property<int>("IdActiveSkill")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescricaoActiveSkill")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("NomeActiveSkill")
                        .IsRequired()
                        .HasColumnType("varchar(120)")
                        .HasMaxLength(120);

                    b.HasKey("IdActiveSkill");

                    b.ToTable("ActiveSkill");
                });

            modelBuilder.Entity("CDMSystem.Dominio.DTO.Classe", b =>
                {
                    b.Property<int>("IdClasse")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AcrClasse")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<string>("ArmaPrimariaClasse")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("ArmaSecundariaClasse")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("ArmaduraClasse")
                        .IsRequired()
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40);

                    b.Property<int>("CritClasse")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("DefClasse")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("DetClasse")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("DmgfClasse")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("DmgmClasse")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("FurClasse")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<string>("HabilidadePassivaClasse")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300);

                    b.Property<int>("HpClasse")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("IdGuildClasse");

                    b.Property<int>("MpClasse")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<string>("NomeClasse")
                        .IsRequired()
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("PenalidadeClasse")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("PericiaArremecoClasse")
                        .IsRequired()
                        .HasColumnType("varchar(1)")
                        .HasMaxLength(1);

                    b.Property<string>("PericiaCorpoCorpoClasse")
                        .IsRequired()
                        .HasColumnType("varchar(1)")
                        .HasMaxLength(1);

                    b.Property<string>("PericiaLaminasClasse")
                        .IsRequired()
                        .HasColumnType("varchar(1)")
                        .HasMaxLength(1);

                    b.Property<string>("PericiaLongaDistanciaClasse")
                        .IsRequired()
                        .HasColumnType("varchar(1)")
                        .HasMaxLength(1);

                    b.Property<string>("StatusClasse")
                        .IsRequired()
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("IdClasse");

                    b.HasIndex("IdGuildClasse");

                    b.ToTable("Classe");
                });

            modelBuilder.Entity("CDMSystem.Dominio.DTO.Cube", b =>
                {
                    b.Property<int>("IdCube")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("QuantidadeItemCube")
                        .HasColumnType("int")
                        .HasMaxLength(3);

                    b.Property<string>("StatusItemCube")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("IdCube");

                    b.ToTable("Cube");
                });

            modelBuilder.Entity("CDMSystem.Dominio.DTO.Guild", b =>
                {
                    b.Property<int>("IdGuild")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescricaoGuild")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("NomeGuild")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdGuild");

                    b.ToTable("Guild");
                });

            modelBuilder.Entity("CDMSystem.Dominio.DTO.Item", b =>
                {
                    b.Property<int>("IdItem")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AcrItem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("CritItem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int?>("CubeIdCube");

                    b.Property<int>("DefItem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<string>("DescricaoItem")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("DetItem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("DmgfItem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("DmgmItem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("FurItem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("HpItem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("IdCubeItem");

                    b.Property<int>("MpItem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<string>("NomeItem")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("RankItem")
                        .IsRequired()
                        .HasColumnType("varchar(3)")
                        .HasMaxLength(3);

                    b.Property<string>("RaridadeItem")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("StatusItem")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("TipoItem")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("IdItem");

                    b.HasIndex("CubeIdCube");

                    b.HasIndex("IdCubeItem");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("CDMSystem.Dominio.DTO.OminiSkill", b =>
                {
                    b.Property<int>("IdOminiSkill")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AreaOminiSkill")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<int?>("ClasseIdClasse");

                    b.Property<string>("CustoOminiSkill")
                        .IsRequired()
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("DescricaoOminiSkill")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("EfeitoOminiSkill")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("ElementoOminiSkill")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("IdClasseOminiSkill");

                    b.Property<int>("IdItemOminiSkill");

                    b.Property<int>("IdSecretOminiSkill");

                    b.Property<int?>("ItemIdItem");

                    b.Property<int>("LevelOminiSkill")
                        .HasColumnType("int")
                        .HasMaxLength(3);

                    b.Property<string>("NomeOminiSkill")
                        .IsRequired()
                        .HasColumnType("varchar(120)")
                        .HasMaxLength(120);

                    b.Property<int?>("SecretIdSecret");

                    b.Property<string>("TipoOminiSkill")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("UsoOminiSkill")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("IdOminiSkill");

                    b.HasIndex("ClasseIdClasse");

                    b.HasIndex("IdClasseOminiSkill");

                    b.HasIndex("IdItemOminiSkill");

                    b.HasIndex("IdSecretOminiSkill");

                    b.HasIndex("ItemIdItem");

                    b.HasIndex("SecretIdSecret");

                    b.ToTable("OminiSkill");
                });

            modelBuilder.Entity("CDMSystem.Dominio.DTO.Personagem", b =>
                {
                    b.Property<int>("IdPersonagem")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AcrPersonagem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("CritPersonagem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("DefPersonagem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("DetPersonagem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("DmgfPersonagem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("DmgmPersonagem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("FurPersonagem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("HpPersonagem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<int>("IdActiveSkillPersonagem");

                    b.Property<int>("IdClassePersonagem");

                    b.Property<int>("IdCubePersonagem");

                    b.Property<int>("IdRacaPersonagem");

                    b.Property<int>("IdSecretPersonagem");

                    b.Property<int>("IdUsuarioPersonagem");

                    b.Property<string>("ImagemPersonagem")
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64);

                    b.Property<int>("LevelPersonagem")
                        .HasColumnType("int")
                        .HasMaxLength(3);

                    b.Property<string>("MarkPersonagem")
                        .HasColumnType("varchar(64)")
                        .HasMaxLength(64);

                    b.Property<int>("MpPersonagem")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<string>("NomePersonagem")
                        .IsRequired()
                        .HasColumnType("varchar(120)")
                        .HasMaxLength(120);

                    b.Property<string>("OrdemPersonagem")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("OspPersonagem")
                        .HasColumnType("int")
                        .HasMaxLength(3);

                    b.Property<int>("SpPersonagem")
                        .HasColumnType("int")
                        .HasMaxLength(3);

                    b.HasKey("IdPersonagem");

                    b.HasIndex("IdActiveSkillPersonagem");

                    b.HasIndex("IdClassePersonagem");

                    b.HasIndex("IdCubePersonagem");

                    b.HasIndex("IdRacaPersonagem");

                    b.HasIndex("IdSecretPersonagem");

                    b.HasIndex("IdUsuarioPersonagem");

                    b.ToTable("Personagem");
                });

            modelBuilder.Entity("CDMSystem.Dominio.DTO.PreRequisito", b =>
                {
                    b.Property<int>("IdPreRequisito")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescricaoPreRequisito")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("IdOminiSkillPreRequisito");

                    b.Property<int?>("OminiSkillIdOminiSkill");

                    b.HasKey("IdPreRequisito");

                    b.HasIndex("IdOminiSkillPreRequisito");

                    b.HasIndex("OminiSkillIdOminiSkill");

                    b.ToTable("PreRequisito");
                });

            modelBuilder.Entity("CDMSystem.Dominio.DTO.Raca", b =>
                {
                    b.Property<int>("IdRaca")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BonusRaca")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("NomeRaca")
                        .IsRequired()
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("RaceSkillRaca")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("IdRaca");

                    b.ToTable("Raca");
                });

            modelBuilder.Entity("CDMSystem.Dominio.DTO.Secret", b =>
                {
                    b.Property<int>("IdSecret")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AposSecret")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("BonusAposSecret")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("BonusSecret")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("DescricaoSecret")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("NomeSecret")
                        .IsRequired()
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("TempoEsperaSecret")
                        .IsRequired()
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("TempoSecret")
                        .IsRequired()
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("IdSecret");

                    b.ToTable("Secret");
                });

            modelBuilder.Entity("CDMSystem.Dominio.DTO.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CpfUsuario")
                        .HasColumnType("numeric(11)")
                        .HasMaxLength(11);

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(120)")
                        .HasMaxLength(120);

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("PermissaoUsuario")
                        .HasColumnType("int(1)")
                        .HasMaxLength(1);

                    b.Property<string>("SenhaUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("SobrenomeUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("CDMSystem.Dominio.DTO.Classe", b =>
                {
                    b.HasOne("CDMSystem.Dominio.DTO.Guild", "GuildClasse")
                        .WithMany()
                        .HasForeignKey("IdGuildClasse")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CDMSystem.Dominio.DTO.Item", b =>
                {
                    b.HasOne("CDMSystem.Dominio.DTO.Cube")
                        .WithMany("ItemCube")
                        .HasForeignKey("CubeIdCube");

                    b.HasOne("CDMSystem.Dominio.DTO.Cube", "CubeItem")
                        .WithMany()
                        .HasForeignKey("IdCubeItem")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CDMSystem.Dominio.DTO.OminiSkill", b =>
                {
                    b.HasOne("CDMSystem.Dominio.DTO.Classe")
                        .WithMany("OminiSkillClasse")
                        .HasForeignKey("ClasseIdClasse");

                    b.HasOne("CDMSystem.Dominio.DTO.Classe", "ClasseOminiSkill")
                        .WithMany()
                        .HasForeignKey("IdClasseOminiSkill")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CDMSystem.Dominio.DTO.Item", "ItemOminiSkill")
                        .WithMany()
                        .HasForeignKey("IdItemOminiSkill")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CDMSystem.Dominio.DTO.Secret", "SecretOminiSkill")
                        .WithMany()
                        .HasForeignKey("IdSecretOminiSkill")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CDMSystem.Dominio.DTO.Item")
                        .WithMany("OminiSkillItem")
                        .HasForeignKey("ItemIdItem");

                    b.HasOne("CDMSystem.Dominio.DTO.Secret")
                        .WithMany("OminiSkillSecret")
                        .HasForeignKey("SecretIdSecret");
                });

            modelBuilder.Entity("CDMSystem.Dominio.DTO.Personagem", b =>
                {
                    b.HasOne("CDMSystem.Dominio.DTO.ActiveSkill", "ActiveSkillPersonagem")
                        .WithMany()
                        .HasForeignKey("IdActiveSkillPersonagem")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CDMSystem.Dominio.DTO.Classe", "ClassePersonagem")
                        .WithMany()
                        .HasForeignKey("IdClassePersonagem")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CDMSystem.Dominio.DTO.Cube", "CubePersonagem")
                        .WithMany()
                        .HasForeignKey("IdCubePersonagem")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CDMSystem.Dominio.DTO.Raca", "RacaPersonagem")
                        .WithMany()
                        .HasForeignKey("IdRacaPersonagem")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CDMSystem.Dominio.DTO.Secret", "SecretPersonagem")
                        .WithMany()
                        .HasForeignKey("IdSecretPersonagem")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CDMSystem.Dominio.DTO.Usuario", "UsuarioPersonagem")
                        .WithMany()
                        .HasForeignKey("IdUsuarioPersonagem")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CDMSystem.Dominio.DTO.PreRequisito", b =>
                {
                    b.HasOne("CDMSystem.Dominio.DTO.OminiSkill", "OminiSkillPreRequisito")
                        .WithMany()
                        .HasForeignKey("IdOminiSkillPreRequisito")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CDMSystem.Dominio.DTO.OminiSkill")
                        .WithMany("PreRequisitoOminiSkill")
                        .HasForeignKey("OminiSkillIdOminiSkill");
                });
#pragma warning restore 612, 618
        }
    }
}
