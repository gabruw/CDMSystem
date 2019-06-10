using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CDMSystem.Repositorio.Config
{
    public class CubeConfiguration : IEntityTypeConfiguration<Dominio.DTO.Cube>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.Cube> builder)
        {
            builder.HasKey(cb => cb.IdCube);

            builder.HasMany(cb => cb.ItemCube).WithOne(i => i.CubeItem);

            builder.Property(cb => cb.QuantidadeItemCube).IsRequired().HasMaxLength(3).HasColumnType("int");
            builder.Property(cb => cb.StatusItemCube).IsRequired().HasMaxLength(10).HasColumnType("varchar");
        }
    }
}