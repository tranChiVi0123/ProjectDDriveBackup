using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using fisrtMVCWeb.Services;

namespace fisrtMVCWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // Đăng kí thêm services ở đây...
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllersWithViews();
            //services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddMvc();
            services.AddTransient<IProductService, ProductService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // else
            // {
            //     app.UseExceptionHandler("/Home/Error");
            //     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //     app.UseHsts();
            // }

            //app.UseMvc();

            // app.UseMiddleware<SimpleMiddleware>();
            // app.UseSimpleMiddeware();
            // app.Use(async (context, next) =>
            // {
            //     await context.Response.WriteAsync("<h1>Hello World from middleware 1</h1>");
            //     await next.Invoke();
            //     await context.Response.WriteAsync("<h1>Returning from middeware 1</h1>");
            // });
            // app.Use(async (context, next) =>
            // {
            //     await context.Response.WriteAsync("<h1>Hello World from middleware 2</h1>");
            //     await next.Invoke();
            //     await context.Response.WriteAsync("<h1>Returning from middeware 2</h1>");
            // });
            // app.Use(async (context, next) =>
            // {
            //     await context.Response.WriteAsync("<h1>Hello World from middleware 3</h1>");
            //     await next.Invoke();
            //     await context.Response.WriteAsync("<h1>Returning from middeware 3</h1>");

            // });
            // app.Run(async (context) =>
            // {
            //     await context.Response.WriteAsync("<h1>" + Configuration.GetSection("Message").Value + "</h1>");
            // });
            // app.Run(async (context) =>
            // {
            //     await context.Response.WriteAsync("<h2>" + Configuration.GetSection("Arg1").Value + "<i>" + Configuration.GetSection("Arg2").Value + "</i></h2>");
            // });
            // app.Run(async (context) =>
            // {
            //     await context.Response.WriteAsync("<h2>" + Configuration.GetSection("textMessage").Value + "</h2>");
            // });

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
