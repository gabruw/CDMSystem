﻿// <auto-generated />
using CDMSystem.Repositorio.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CDMSystem.Repositorio.Migrations
{
    [DbContext(typeof(CDMSystemContext))]
    [Migration("20190610141307_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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

                    b.HasKey("IdGuild")
                        .HasName("PK_IdGuild");

                    b.ToTable("Guild");
                });
#pragma warning restore 612, 618
        }
    }
}
