﻿using CDMSystem.Repositorio.Config;
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
            modelBuilder.ApplyConfiguration(new PersonagemConfiguration());
            modelBuilder.ApplyConfiguration(new RacaConfiguration());
            modelBuilder.ApplyConfiguration(new SecretConfiguration());
            modelBuilder.ApplyConfiguration(new ClasseConfiguration());
            modelBuilder.ApplyConfiguration(new ActiveSkillConfiguration());
            modelBuilder.ApplyConfiguration(new OminiSkillConfiguration());
            modelBuilder.ApplyConfiguration(new GuildConfiguration());

            base.OnModelCreating(modelBuilder);
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