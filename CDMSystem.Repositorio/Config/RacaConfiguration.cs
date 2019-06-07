using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDMSystem.Repositorio.Config
{
    public class RacaConfiguration : IEntityTypeConfiguration<Dominio.DTO.Raca>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.Raca> builder)
        {
            builder.HasKey(r => r.IdRaca);

            builder.Property(r => r.NomeRaca).IsRequired().HasMaxLength(40).HasColumnType("varchar");
            builder.Property(r => r.BonusRaca).IsRequired().HasMaxLength(300).HasColumnType("varchar");
            builder.Property(r => r.RaceSkillRaca).IsRequired().HasMaxLength(300).HasColumnType("varchar");
        }
    }
}