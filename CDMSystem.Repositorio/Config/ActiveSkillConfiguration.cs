using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDMSystem.Repositorio.Config
{
    public class ActiveSkillConfiguration : IEntityTypeConfiguration<Dominio.DTO.ActiveSkill>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.ActiveSkill> builder)
        {
            builder.HasKey(acs => acs.IdActiveSkill);

            builder.Property(acs => acs.NomeActiveSkill).IsRequired().HasMaxLength(120).HasColumnType("varchar");
            builder.Property(acs => acs.DescricaoActiveSkill).IsRequired().HasMaxLength(500).HasColumnType("varchar");
        }
    }
}