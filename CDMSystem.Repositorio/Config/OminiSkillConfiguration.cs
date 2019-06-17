using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CDMSystem.Repositorio.Config
{
    public class OminiSkillConfiguration : IEntityTypeConfiguration<Dominio.DTO.OminiSkill>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.OminiSkill> builder)
        {
            builder.HasKey(o => o.IdOminiSkill);

            builder.HasOne(o => o.ClasseOminiSkill).WithMany().HasForeignKey(o => o.IdClasseOminiSkill);
            builder.HasOne(o => o.SecretOminiSkill).WithMany().HasForeignKey(o => o.IdSecretOminiSkill);
            builder.HasOne(o => o.ItemOminiSkill).WithMany().HasForeignKey(o => o.IdItemOminiSkill);

            builder.Property(o => o.NomeOminiSkill).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(o => o.TipoOminiSkill).IsRequired().HasMaxLength(10).HasColumnType("varchar(10)");
            builder.Property(o => o.ElementoOminiSkill).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(o => o.DescricaoOminiSkill).IsRequired().HasMaxLength(500).HasColumnType("varchar(500)");
            builder.Property(o => o.EfeitoOminiSkill).IsRequired().HasMaxLength(300).HasColumnType("varchar(300)");
            builder.Property(o => o.CustoOminiSkill).IsRequired().HasMaxLength(5).HasColumnType("varchar(5)");
            builder.Property(o => o.AreaOminiSkill).IsRequired().HasMaxLength(15).HasColumnType("varchar(15)");
            builder.Property(o => o.LevelOminiSkill).IsRequired().HasMaxLength(3).HasColumnType("int");
            builder.Property(o => o.UsoOminiSkill).IsRequired().HasMaxLength(15).HasColumnType("varchar(15)");

            builder.HasMany(o => o.PreRequisitoOminiSkill).WithOne(pr => pr.OminiSkillPreRequisito).HasForeignKey(pr => pr.IdPreRequisito);
        }
    }
}