using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Portfolio.WebUI.Model.DataContexts;

namespace Portfolio.WebUI
{
    public class Startup
    {
        readonly IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();


            // Dependency Injection Isdifade edilmesi ucun yazilmisdir+
            services.AddDbContext<PortfolioDbContext>(cfg =>
            {

                // ve burda cagirib yaziriq appsettings adini 
                cfg.UseSqlServer(configuration.GetConnectionString("cString"));

            }, ServiceLifetime.Scoped);

            services.AddMediatR(this.GetType().Assembly);


            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(cfg =>
            {

                cfg.MapControllerRoute("default", "{controller=Home}/{action=index}/{id?}");

            });

        }
    }
}
