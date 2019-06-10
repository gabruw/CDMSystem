using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CDMSystem.Repositorio.Config
{
    public class GuildConfiguration : IEntityTypeConfiguration<Dominio.DTO.Guild>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.Guild> builder)
        {
            builder.HasKey(g => g.IdGuild);

            builder.Property(g => g.NomeGuild).IsRequired().HasMaxLength(60).HasColumnType("varchar");
            builder.Property(g => g.DescricaoGuild).IsRequired().HasMaxLength(500).HasColumnType("varchar");
        }
    }
}