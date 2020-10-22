
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BullService.Abstraction;
using BullService.Models.DbContexts;
using BullService.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace BullService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CowAPI", Version = "v1" });
            });
            services.AddScoped<ICowRepository, CowRepository>();
            services.AddDbContextPool<CowDbContext>(options =>
                //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
                options.UseMySql(Configuration.GetConnectionString("MySqlConnection"), mysqlOptions=> mysqlOptions.ServerVersion(new Pomelo.EntityFrameworkCore.MySql.Storage.ServerVersion(new Version(10, 3, 21), ServerType.MariaDb))));

            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "../AngularApp/dist";
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            try
            {
                using (var migrationSvcScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                    .CreateScope())
                {
                    migrationSvcScope.ServiceProvider.GetService<CowDbContext>().Database.Migrate();
                }
            }
            catch (Exception e) { }
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cow API V1");
            });
            app.UseSpaStaticFiles();
            app.UseCors(builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .SetIsOriginAllowed((host) => true)
                .AllowCredentials()
            );
            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseRewriter(new RewriteOptions()
                .AddRedirect("index.html", "/"));

            //app.UseSpa(spa =>
            //{
            //    // To learn more about options for serving an Angular SPA from ASP.NET Core,
            //    // see https://go.microsoft.com/fwlink/?linkid=864501

            //    spa.Options.SourcePath = "../AngularApp";

            //    //if (env.IsDevelopment())
            //    //{
            //    //    //spa.UseAngularCliServer(npmScript: "start");
            //    //    spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
            //    //}
            //});
        }
    }
}
