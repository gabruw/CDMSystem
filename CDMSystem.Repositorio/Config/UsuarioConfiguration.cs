using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CDMSystem.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Dominio.DTO.Usuario>
    {
        public void Configure(EntityTypeBuilder<Dominio.DTO.Usuario> builder)
        {
            builder.HasKey(u => u.IdUsuario);

            builder.Property(u => u.EmailUsuario).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(u => u.SenhaUsuario).IsRequired().HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(u => u.NomeUsuario).IsRequired().HasMaxLength(30).HasColumnType("varchar(30)");
            builder.Property(u => u.SobrenomeUsuario).IsRequired().HasMaxLength(200).HasColumnType("varchar(200)");
            builder.Property(u => u.CpfUsuario).IsRequired().HasMaxLength(11).HasColumnType("numeric(11)");
            builder.Property(u => u.PermissaoUsuario).IsRequired().HasMaxLength(1).HasColumnType("int(1)");
        }
    }
}