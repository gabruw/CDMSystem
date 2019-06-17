using CDMSystem.Dominio.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CDMSystem.Repositorio.Config
{
    public class ItemConfiguration : IEntityTypeConfiguration<Dominio.DTO.Item>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.Item> builder)
        {
            builder.HasKey(i => i.IdItem);

            builder.HasOne(i => i.CubeItem).WithMany().HasForeignKey(i => i.IdCubeItem);

            builder.Property(i => i.NomeItem).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(i => i.DescricaoItem).IsRequired().HasMaxLength(500).HasColumnType("varchar(500)");
            builder.Property(i => i.RaridadeItem).IsRequired().HasMaxLength(10).HasColumnType("varchar(10)");
            builder.Property(i => i.RankItem).IsRequired().HasMaxLength(3).HasColumnType("varchar(3)");
            builder.Property(i => i.TipoItem).IsRequired().HasMaxLength(20).HasColumnType("varchar(20)");
            builder.Property(i => i.StatusItem).IsRequired().HasMaxLength(20).HasColumnType("varchar(20)");

            builder.Property(i => i.HpItem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(i => i.MpItem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(i => i.DmgfItem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(i => i.DmgmItem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(i => i.DefItem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(i => i.FurItem).IsRequired().HasMaxLength(3).HasColumnType("int");
            builder.Property(i => i.DetItem).IsRequired().HasMaxLength(3).HasColumnType("int");
            builder.Property(i => i.CritItem).IsRequired().HasMaxLength(3).HasColumnType("int");
            builder.Property(i => i.AcrItem).IsRequired().HasMaxLength(3).HasColumnType("int");

            builder.HasMany(i => i.OminiSkillItem).WithOne(os => os.ItemOminiSkill).HasForeignKey(os => os.IdOminiSkill);
        }
    }
}