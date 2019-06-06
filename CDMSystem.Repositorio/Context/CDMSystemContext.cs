using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace CDMSystem.Repositorio.Context
{
    public class CDMSystemContext : DbContext
    {
        public CDMSystemContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Personagem> Personagems { get; set; }

        public DbSet<Classe> Classe { get; set; }

        public DbSet<Raca> Racas { get; set; }

        public DbSet<Guild> Guild { get; set; }

        public DbSet<Secret> Secret { get; set; }

        public DbSet<ActiveSkill> ActiveSkill { get; set; }

        public DbSet<OminiSkill> OminiSkill { get; set; }  
    }
}