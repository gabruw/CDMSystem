using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CDMSystem.Repositorio.Config
{
    public class CoreConfiguration : IEntityTypeConfiguration<Dominio.DTO.Core>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.Core> builder)
        {
            builder.HasKey(cr => cr.IdCore);

            builder.Property(cr => cr.NomeCore).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(cr => cr.DescricaoCore).IsRequired().HasMaxLength(300).HasColumnType("varchar(300)");
            builder.Property(cr => cr.TipoCore).IsRequired().HasMaxLength(10).HasColumnType("varchar(10)");

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