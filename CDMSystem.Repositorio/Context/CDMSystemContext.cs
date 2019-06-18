using CDMSystem.Dominio.DTO;
using CDMSystem.Repositorio.Config;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace CDMSystem.Repositorio.Context
{
    public class CDMSystemContext : DbContext
    {
        public CDMSystemContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Raca>();
            modelBuilder.Ignore<Cube>();
            modelBuilder.Ignore<Item>();
            modelBuilder.Ignore<Guild>();
            modelBuilder.Ignore<Secret>();
            modelBuilder.Ignore<Classe>();
            modelBuilder.Ignore<Usuario>();
            modelBuilder.Ignore<Personagem>();
            modelBuilder.Ignore<RaceSkill>();
            modelBuilder.Ignore<OminiSkill>();
            modelBuilder.Ignore<ActiveSkill>();
            modelBuilder.Ignore<PreRequisito>();

            modelBuilder.ApplyConfiguration(new RacaConfiguration());
            modelBuilder.ApplyConfiguration(new CubeConfiguration());
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new GuildConfiguration());
            modelBuilder.ApplyConfiguration(new SecretConfiguration());
            modelBuilder.ApplyConfiguration(new ClasseConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new RaceSkillConfiguration());
            modelBuilder.ApplyConfiguration(new OminiSkillConfiguration());
            modelBuilder.ApplyConfiguration(new PersonagemConfiguration());
            modelBuilder.ApplyConfiguration(new ActiveSkillConfiguration());
            modelBuilder.ApplyConfiguration(new PreRequisitoConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Raca> Raca { get; set; }

        public DbSet<Cube> Cube { get; set; }

        public DbSet<Item> Item { get; set; }

        public DbSet<Guild> Guild { get; set; }

        public DbSet<Secret> Secret { get; set; }

        public DbSet<Classe> Classe { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Personagem> Personagem { get; set; }

        public DbSet<RaceSkill> RaceSkill { get; set; }

        public DbSet<OminiSkill> OminiSkill { get; set; }

        public DbSet<ActiveSkill> ActiveSkill { get; set; }

        public DbSet<PreRequisito> PreRequisito { get; set; }
    }
}