using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Portfolio.WebUI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(cfg=> {

                cfg.MapControllerRoute("default", "{controller=Home}/{action=index}/{id?}");

            });

        }
    }
}
