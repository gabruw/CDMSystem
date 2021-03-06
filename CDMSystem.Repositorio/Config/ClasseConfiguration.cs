﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CDMSystem.Repositorio.Config
{
    public class ClasseConfiguration : IEntityTypeConfiguration<Dominio.DTO.Classe>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.Classe> builder)
        {
            builder.HasKey(c => c.IdClasse);

            builder.HasOne(c => c.GuildClasse).WithMany().HasForeignKey(c => c.IdGuildClasse);

            builder.HasMany(c => c.OminiSkillClasse).WithOne(os => os.ClasseOminiSkill).HasForeignKey(os => os.IdOminiSkill);

            builder.Property(c => c.NomeClasse).IsRequired().HasMaxLength(40).HasColumnType("varchar(40)");
            builder.Property(c => c.StatusClasse).IsRequired().HasMaxLength(40).HasColumnType("varchar(40)");
            builder.Property(c => c.ArmaduraClasse).IsRequired().HasMaxLength(40).HasColumnType("varchar(40)");
            builder.Property(c => c.ArmaPrimariaClasse).IsRequired().HasMaxLength(60).HasColumnType("varchar(60)");
            builder.Property(c => c.ArmaSecundariaClasse).IsRequired().HasMaxLength(60).HasColumnType("varchar(60)");
            builder.Property(c => c.PenalidadeClasse).IsRequired().HasMaxLength(300).HasColumnType("varchar(300)");
            builder.Property(c => c.HabilidadePassivaClasse).IsRequired().HasMaxLength(300).HasColumnType("varchar(300)");

            builder.Property(c => c.HpClasse).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(c => c.MpClasse).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(c => c.DmgfClasse).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(c => c.DmgmClasse).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(c => c.DefClasse).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(c => c.FurClasse).IsRequired().HasMaxLength(3).HasColumnType("int");
            builder.Property(c => c.DetClasse).IsRequired().HasMaxLength(3).HasColumnType("int");
            builder.Property(c => c.CritClasse).IsRequired().HasMaxLength(3).HasColumnType("int");
            builder.Property(c => c.AcrClasse).IsRequired().HasMaxLength(3).HasColumnType("int");

            builder.Property(c => c.PericiaLaminasClasse).IsRequired().HasMaxLength(1).HasColumnType("varchar(1)");
            builder.Property(c => c.PericiaLongaDistanciaClasse).IsRequired().HasMaxLength(1).HasColumnType("varchar(1)");
            builder.Property(c => c.PericiaArremecoClasse).IsRequired().HasMaxLength(1).HasColumnType("varchar(1)");
            builder.Property(c => c.PericiaCorpoCorpoClasse).IsRequired().HasMaxLength(1).HasColumnType("varchar(1)");
        }
    }
}