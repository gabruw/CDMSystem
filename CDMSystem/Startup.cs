using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CDMSystem.Repositorio.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CDMSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            var Builder = new ConfigurationBuilder();
            Builder.AddJsonFile("config.json", optional: false, reloadOnChange: true);

            Configuration = Builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // DB Connection
            //var connectionString = Configuration.GetConnectionString("db_CDMSystem");
            //services.AddDbContext<CDMSystemContext>(option =>
            //                                                option.UseLazyLoadingProxies().UseMySql(connectionString,
            //                                                    m => m.MigrationsAssembly("CDMSystem.Repositorio")));

            var connectionString = Configuration.GetConnectionString("CDMSystemDB");
            services.AddDbContext<CDMSystemContext>(option =>
                                                            option.UseLazyLoadingProxies().UseMySql(connectionString,
                                                                m => m.MigrationsAssembly("CDMSystem.Repositorio")));

            // Scope's
            services.AddScoped<Dominio.Repository.IActiveSkillRepository, Repositorio.ActiveSkillRepository>();
            services.AddScoped<Dominio.Repository.IClasseRepository, Repositorio.ClasseRepository>();
            services.AddScoped<Dominio.Repository.ICubeRepository, Repositorio.Repository.CubeRepository>();
            services.AddScoped<Dominio.Repository.IGuildRepository, Repositorio.GuildRepository>();
            services.AddScoped<Dominio.Repository.IItemRepository, Repositorio.Repository.ItemRepository>();
            services.AddScoped<Dominio.Repository.IOminiSkillRepository, Repositorio.OminiSkillRepository>();
            services.AddScoped<Dominio.Repository.IPersonagemRepository, Repositorio.PersonagemRepository>();
            services.AddScoped<Dominio.Repository.IPreRequisitoRepository, Repositorio.PreRequisitoRepository>();
            services.AddScoped<Dominio.Repository.IRacaRepository, Repositorio.RacaRepository>();
            services.AddScoped<Dominio.Repository.IRaceSkillRepository, Repositorio.RaceSkillRepository>();
            services.AddScoped<Dominio.Repository.ISecretRepository, Repositorio.SecretRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" }
                );
            });
        }
    }
}
