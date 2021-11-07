using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Portfolio.Domain.Model.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebApi
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
            services.AddControllers();

            services.AddRouting(cfg => cfg.LowercaseUrls = true);

            // Dependency Injection Isdifade edilmesi ucun yazilmisdir+
            services.AddDbContext<PortfolioDbContext>(cfg =>
            {

                // ve burda cagirib yaziriq appsettings adini 
                cfg.UseSqlServer(configuration.GetConnectionString("cString"));

            }, ServiceLifetime.Scoped);
            //MediarR ucun yazilmisdir.
            // services.AddMediatR(this.GetType().Assembly);
            //Proyect hisselere bolurukse bu cur yazilmalidir.
            var assemply = AppDomain.CurrentDomain.GetAssemblies().Where(p => p.FullName.StartsWith("Portfolio.")).ToArray();
            services.AddMediatR(assemply);
            //Mediart CreateCommand Yazilib
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

            //Swager uun yazilib
            services.AddSwaggerGen(c =>
            {
                //Anotaion ucun yazilib
                c.EnableAnnotations();
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();


            //Swager uun yazilib

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseEndpoints(cfg=> {

                cfg.MapControllers();
            
            });
        }
    }
}
