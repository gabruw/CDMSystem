using CDMSystem.Dominio.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDMSystem.Repositorio.Config
{
    public class CoreConfiguration : IEntityTypeConfiguration<Dominio.DTO.Core>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.Core> builder)
        {
            builder.HasKey(cr => cr.IdCore);

            builder.Property(cr => cr.HpCore).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(cr => cr.MpCore).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(cr => cr.DmgfCore).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(cr => cr.DmgmCore).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(cr => cr.DefCore).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(cr => cr.FurCore).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(cr => cr.DetCore).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(cr => cr.CritCore).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(cr => cr.AcrCore).IsRequired().HasMaxLength(4).HasColumnType("int");
        }
    }
}