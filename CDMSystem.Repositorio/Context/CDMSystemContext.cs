using Microsoft.EntityFrameworkCore;

namespace CDMSystem.Repositorio.Context
{
    public class CDMSystemContext : DbContext
    {
        public DbSet<Personagem> Personagems { get; set; }

        public DbSet<Raca> Racas { get; set; }
    }
}