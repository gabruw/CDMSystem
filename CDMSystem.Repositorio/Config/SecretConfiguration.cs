using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDMSystem.Repositorio.Config
{
    public class SecretConfiguration : IEntityTypeConfiguration<Dominio.DTO.Secret>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.Secret> builder)
        {
            builder.HasKey(s => s.IdSecret);

            //builder.Property(s => s.OminiSkillSecret);

            builder.Property(s => s.NomeSecret).IsRequired().HasMaxLength(40).HasColumnType("varchar");
            builder.Property(s => s.TempoSecret).IsRequired().HasMaxLength(40).HasColumnType("varchar");
            builder.Property(s => s.TempoEsperaSecret).IsRequired().HasMaxLength(40).HasColumnType("varchar");
            builder.Property(s => s.AposSecret).IsRequired().HasMaxLength(300).HasColumnType("varchar");
            builder.Property(s => s.BonusAposSecret).IsRequired().HasMaxLength(300).HasColumnType("varchar");
            builder.Property(s => s.BonusSecret).IsRequired().HasMaxLength(300).HasColumnType("varchar");
            builder.Property(s => s.DescricaoSecret).IsRequired().HasMaxLength(300).HasColumnType("varchar");
        }
    }
}