using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VendasWebMVC.Data;

namespace VendasWebMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Este método é chamado pelo tempo de execução. Use este método para adicionar serviços ao projeto
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //RECUPERANDO A STRING DE CONEXAO E CRIANDO CONTEXTO
            //Abaixo é criado o contexto, recuperando a string de conexão declarada no appsettings.json

            //Conexao do SqlServer
            services.AddDbContext<VendasWebMVCContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("VendasWebMVCContext")));

            //Conexao MySQL
            //Para usar o MySql precisamos instalar as dependencias do banco MySql via Nuget
            //Comando: Install-Package Pomelo.EntityFrameworkCore.MySql
            //services.AddDbContext<VendasWebMVCContext>(options =>
            //        options.UseMySql(Configuration.GetConnectionString("VendasWebMVCContext"), builder =>  //"" = nome da classe de contexto
            //            builder.MigrationsAssembly("VendasWebMVC"))); //Nome do Projeto

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
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
