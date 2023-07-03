using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SlimeTAP.RazorPages.Data;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace SlimeTAP
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddDbContext<AppDbContext>();
            services.AddDistributedMemoryCache();
            services.AddHttpContextAccessor();
            
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSession(options =>
            {
                options.Cookie.Name = "UsuarioNome";
                options.IdleTimeout = TimeSpan.FromMinutes(30); // Define o tempo de expiração da sessão
                options.Cookie.HttpOnly = true; // Define o cookie como acessível apenas pelo servidor

            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            // Configurar serviços
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(options =>
            {
                // Configure as opções de sessão, se necessário
            });

            var app = builder.Build();
            
            // Configurar pipeline de requisição
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.MapRazorPages();

            app.Run();
        }
    }
}
