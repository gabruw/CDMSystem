using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CDMSystem.Repositorio.Config
{
    public class RaceSkillConfiguration : IEntityTypeConfiguration<Dominio.DTO.RaceSkill>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.RaceSkill> builder)
        {
            builder.HasKey(rs => rs.IdRaceSkill);

            builder.HasOne(rs => rs.RacaRaceSkill).WithMany().HasForeignKey(rs => rs.IdRacaRaceSkill);

            builder.Property(rs => rs.NomeRaceSkill).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(rs => rs.TipoRaceSkill).IsRequired().HasMaxLength(10).HasColumnType("varchar(10)");
            builder.Property(rs => rs.ElementoRaceSkill).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(rs => rs.DescricaoRaceSkill).IsRequired().HasMaxLength(500).HasColumnType("varchar(500)");
            builder.Property(rs => rs.EfeitoRaceSkill).IsRequired().HasMaxLength(300).HasColumnType("varchar(300)");
            builder.Property(rs => rs.CustoRaceSkill).IsRequired().HasMaxLength(5).HasColumnType("varchar(5)");
            builder.Property(rs => rs.AreaRaceSkill).IsRequired().HasMaxLength(15).HasColumnType("varchar(15)");
            builder.Property(rs => rs.LevelRaceSkill).IsRequired().HasMaxLength(3).HasColumnType("int");
            builder.Property(rs => rs.UsoRaceSkill).IsRequired().HasMaxLength(15).HasColumnType("varchar(15)");

            builder.HasMany(rs => rs.PreRequisitoRaceSkill).WithOne(pr => pr.RaceSkillPreRequisito).HasForeignKey(pr => pr.IdPreRequisito);
        }
    }
}