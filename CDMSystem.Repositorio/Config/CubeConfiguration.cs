using CDMSystem.Dominio.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDMSystem.Repositorio.Config
{
    public class CubeConfiguration : IEntityTypeConfiguration<Dominio.DTO.Cube>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.Cube> builder)
        {
            builder.HasKey(cb => cb.IdCube);

            builder.Property(cb => cb.NomeItemCube).IsRequired().HasMaxLength(100).HasColumnType("varchar");
            builder.Property(cb => cb.QuantidadeItemCube).IsRequired().HasMaxLength(3).HasColumnType("int");
            builder.Property(cb => cb.DescricaoItemCube).IsRequired().HasMaxLength(500).HasColumnType("varchar");
        }
    }
}