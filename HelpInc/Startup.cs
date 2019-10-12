using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Context;

namespace HelpInc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.Cookie.Name = ".HelpInc.Session";
                options.IdleTimeout = TimeSpan.FromDays(1);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // DB Connection
            var connectionString = Configuration.GetConnectionString("db_HelpInc");
            services.AddDbContext<HelpIncContext>(option => option.UseLazyLoadingProxies().UseMySql(connectionString, migration => migration.MigrationsAssembly("Repository")));

            // Scope's
            services.AddScoped<Domain.Repository.IConsumidorRepository, Repository.Repository.ConsumidorRepository>();
            services.AddScoped<Domain.Repository.IEmpresaRepository, Repository.Repository.EmpresaRepository>();
            services.AddScoped<Domain.Repository.IEnderecoRepository, Repository.Repository.EnderecoRepository>();
            services.AddScoped<Domain.Repository.IGrupoRepository, Repository.Repository.GrupoRepository>();
            services.AddScoped<Domain.Repository.IHabilidadeRepository, Repository.Repository.HabilidadeRepository>();
            services.AddScoped<Domain.Repository.ILoginRepository, Repository.Repository.LoginRepository>();
            services.AddScoped<Domain.Repository.IMensagemRepository, Repository.Repository.MensagemRepository>();
            services.AddScoped<Domain.Repository.IPrestadorRepository, Repository.Repository.PrestadorRepository>();
        }

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
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
