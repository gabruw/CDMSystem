using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CDMSystem.Repositorio.Config
{
    public class SecretConfiguration : IEntityTypeConfiguration<Dominio.DTO.Secret>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.Secret> builder)
        {
            builder.HasKey(s => s.IdSecret);

            builder.HasMany(s => s.OminiSkillSecret).WithOne(os => os.SecretOminiSkill).HasForeignKey(os => os.IdOminiSkill);

            builder.Property(s => s.NomeSecret).IsRequired().HasMaxLength(40).HasColumnType("varchar(40)");
            builder.Property(s => s.TempoSecret).IsRequired().HasMaxLength(40).HasColumnType("varchar(40)");
            builder.Property(s => s.TempoEsperaSecret).IsRequired().HasMaxLength(40).HasColumnType("varchar(40)");
            builder.Property(s => s.AposSecret).IsRequired().HasMaxLength(300).HasColumnType("varchar(300)");
            builder.Property(s => s.BonusAposSecret).IsRequired().HasMaxLength(300).HasColumnType("varchar(300)");
            builder.Property(s => s.BonusSecret).IsRequired().HasMaxLength(300).HasColumnType("varchar(300)");
            builder.Property(s => s.DescricaoSecret).IsRequired().HasMaxLength(300).HasColumnType("varchar(300)");
        }
    }
}