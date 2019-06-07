using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDMSystem.Repositorio.Config
{
    public class PersonagemConfiguration : IEntityTypeConfiguration<Dominio.DTO.Personagem>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.Personagem> builder)
        {
            builder.HasKey(p => p.IdPersonagem);

            builder.Property(p => p.IdClassePersonagem);
            builder.Property(p => p.IdRacaPersonagem);
            builder.Property(p => p.IdActiveSkillPersonagem);
            builder.Property(p => p.IdSecretPersonagem);
            builder.Property(p => p.IdCubePersonagem);

            builder.Property(p => p.NomePersonagem).IsRequired().HasMaxLength(120).HasColumnType("varchar");
            builder.Property(p => p.OrdemPersonagem).IsRequired().HasMaxLength(30).HasColumnType("int");
            builder.Property(p => p.LevelPersonagem).IsRequired().HasMaxLength(3).HasColumnType("int");
            builder.Property(p => p.OspPersonagem).HasMaxLength(3).HasColumnType("int");
            builder.Property(p => p.SpPersonagem).HasMaxLength(3).HasColumnType("int");
            builder.Property(p => p.MarkPersonagem).HasMaxLength(64).HasColumnType("varchar");
            builder.Property(p => p.ImagemPersonagem).HasMaxLength(64).HasColumnType("varchar");

            builder.Property(p => p.HpPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(p => p.MpPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(p => p.DmgfPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(p => p.DmgmPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(p => p.DefPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(p => p.FurPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(p => p.DetPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(p => p.CritPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(p => p.AcrPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");

            //builder.HasOne(p => p.ElmoPersonagem);
            //builder.HasOne(p => p.PeitoralPersonagem);
            //builder.HasOne(p => p.BracoDireitoPersonagem);
            //builder.HasOne(p => p.BracoEsquerdoPersonagem);
            //builder.HasOne(p => p.CalcaPersonagem);
            //builder.HasOne(p => p.BotaPersonagem);
            //builder.HasOne(p => p.PendantePersonagem);
            //builder.HasOne(p => p.AnelDireitoPersonagem);
            //builder.HasOne(p => p.AnelEsquerdoPersonagem);
            //builder.HasOne(p => p.ArmaPrimariaPersonagem);
            //builder.HasOne(p => p.ArmaSecundariaPersonagem);
        }
    }
}