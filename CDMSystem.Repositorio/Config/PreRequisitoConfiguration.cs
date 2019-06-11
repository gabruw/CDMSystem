using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CDMSystem.Repositorio.Config
{
    public class PreRequisitoConfiguration : IEntityTypeConfiguration<Dominio.DTO.PreRequisito>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.PreRequisito> builder)
        {
            builder.HasKey(pr => pr.IdPreRequisito);

            builder.Property(pr => pr.DescricaoPreRequisito).IsRequired().HasMaxLength(500).HasColumnType("varchar(500)");

            builder.HasOne(pr => pr.OminiSkillPreRequisito).WithMany().HasForeignKey(o => o.IdOminiSkillPreRequisito);
        }
    }
}