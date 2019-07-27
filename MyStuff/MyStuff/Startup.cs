using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyStuff.Data;
using MyStuff.Services;

namespace MyStuff
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;          
        }


        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddAuthentication();
            services.AddMvc();
            services.AddDbContext<MyStuffdbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("Azure")));
            services.AddScoped<ISoftwareData, InMemorySoftwareData>();
            services.AddScoped<IBookData, SqlBookData>();
            services.AddScoped<IProjectData, SqlProjectData>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //app.UseAuthentication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
          
            app.UseStaticFiles();
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(name: "default",
            //    template: "{controller=Projects}/{action=Index}/");
            //});
            //app.UseMvc();
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Fall through");
            });
        }
    }
}
