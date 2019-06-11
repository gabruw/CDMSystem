using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CDMSystem.Repositorio.Config
{
    public class PersonagemConfiguration : IEntityTypeConfiguration<Dominio.DTO.Personagem>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.Personagem> builder)
        {
            builder.HasKey(p => p.IdPersonagem);

            builder.HasOne(p => p.ClassePersonagem).WithMany().HasForeignKey(p => p.IdClassePersonagem);
            builder.HasOne(p => p.RacaPersonagem).WithMany().HasForeignKey(p => p.IdRacaPersonagem);
            builder.HasOne(p => p.ActiveSkillPersonagem).WithMany().HasForeignKey(p => p.IdActiveSkillPersonagem);
            builder.HasOne(p => p.SecretPersonagem).WithMany().HasForeignKey(p => p.IdSecretPersonagem);
            builder.HasOne(p => p.CubePersonagem).WithMany().HasForeignKey(p => p.IdCubePersonagem);

            builder.Property(p => p.NomePersonagem).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(p => p.OrdemPersonagem).IsRequired().HasMaxLength(30).HasColumnType("varchar(30)");
            builder.Property(p => p.LevelPersonagem).IsRequired().HasMaxLength(3).HasColumnType("int");
            builder.Property(p => p.OspPersonagem).HasMaxLength(3).HasColumnType("int");
            builder.Property(p => p.SpPersonagem).HasMaxLength(3).HasColumnType("int");
            builder.Property(p => p.MarkPersonagem).HasMaxLength(64).HasColumnType("varchar(64)");
            builder.Property(p => p.ImagemPersonagem).HasMaxLength(64).HasColumnType("varchar(64)");

            builder.Property(p => p.HpPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(p => p.MpPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(p => p.DmgfPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(p => p.DmgmPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(p => p.DefPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(p => p.FurPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(p => p.DetPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(p => p.CritPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
            builder.Property(p => p.AcrPersonagem).IsRequired().HasMaxLength(4).HasColumnType("int");
        }
    }
}