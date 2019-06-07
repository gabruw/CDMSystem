using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDMSystem.Repositorio.Config
{
    public class ClasseConfiguration : IEntityTypeConfiguration<Dominio.DTO.Classe>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.Classe> builder)
        {
            builder.HasKey(c => c.IdClasse);

            builder.Property(c => c.IdGuildClasse);

            builder.Property(c => c.NomeClasse).IsRequired().HasMaxLength(40).HasColumnType("varchar");
            builder.Property(c => c.StatusClasse).IsRequired().HasMaxLength(40).HasColumnType("varchar");
            builder.Property(c => c.ArmaduraClasse).IsRequired().HasMaxLength(40).HasColumnType("varchar");
            builder.Property(c => c.ArmaPrimariaClasse).IsRequired().HasMaxLength(60).HasColumnType("varchar");
            builder.Property(c => c.ArmaSecundariaClasse).IsRequired().HasMaxLength(60).HasColumnType("varchar");
            builder.Property(c => c.PenalidadeClasse).IsRequired().HasMaxLength(300).HasColumnType("varchar");
            builder.Property(c => c.HabilidadePassivaClasse).IsRequired().HasMaxLength(300).HasColumnType("varchar");

            builder.Property(c => c.HpClasse).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(c => c.MpClasse).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(c => c.DmgfClasse).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(c => c.DmgmClasse).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(c => c.DefClasse).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(c => c.FurClasse).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(c => c.DetClasse).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(c => c.CritClasse).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(c => c.AcrClasse).IsRequired().HasMaxLength(4).HasColumnType("int");

            builder.Property(c => c.PericiaLaminasClasse).IsRequired().HasMaxLength(1).HasColumnType("varchar");
            builder.Property(c => c.PericiaLongaDistanciaClasse).IsRequired().HasMaxLength(1).HasColumnType("varchar");
            builder.Property(c => c.PericiaArremecoClasse).IsRequired().HasMaxLength(1).HasColumnType("varchar");
            builder.Property(c => c.PericiaCorpoCorpoClasse).IsRequired().HasMaxLength(1).HasColumnType("varchar");
        }
    }
}