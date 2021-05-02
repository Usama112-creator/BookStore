using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)// is used to add all dependencies
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)//Used for http pipeleine
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.Use(async (context,next)=>
            //{
            //    await context.Response.WriteAsync("Hello from 1st midllerware");
            //    await next();
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from 2nd midllerware");
            //    await next();
            //});

            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //endpoints.MapGet("/", async context =>
                //{
                //    //if(env.IsDevelopment())
                //    //{
                //    //    await context.Response.WriteAsync("Hello from Development");
                //    //}
                //    //else if(env.IsProduction())
                //    //{
                //    //    await context.Response.WriteAsync("Hello from production");
                //    //}
                //    //else if(env.IsStaging())
                //    //{
                //    //    await context.Response.WriteAsync("hello from stagging");
                //    //}
                //    //else
                //    //{
                //    //    await context.Response.WriteAsync(env.EnvironmentName);
                //    //}
                //    endpoints.MapDefaultControllerRoute();
                //});
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Usama", async context =>
                {
                    await context.Response.WriteAsync("Hello World Usama!");
                });
            });
        }
    }
}
