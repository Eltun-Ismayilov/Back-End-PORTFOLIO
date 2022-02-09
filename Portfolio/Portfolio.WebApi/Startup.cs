using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Portfolio.Domain.Model.DataContexts;
using System;
using System.Linq;
using System.Text;

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
            services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy = null;
                })
                .AddNewtonsoftJson(cfg =>
            {
                cfg.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

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

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "Jwt Authorization",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"

                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference=new OpenApiReference
                            {
                                Type=ReferenceType.SecurityScheme,
                                Id="Bearer"
                            }
                        },
                        new string[]{ }
                    }
                });
            });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration["Jwt:Issuer"],
                    ValidAudience = configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:key"]))

                };
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            //Swager uun yazilib

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseEndpoints(cfg =>
            {

                cfg.MapControllers();

            });
        }
    }
}
