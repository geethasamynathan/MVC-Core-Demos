using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo1.Model;
namespace Demo1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                //DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions
                //{
                //    SourceCodeLineCount = 10
                //};
                //app.UseDeveloperExceptionPage(developerExceptionPageOptions);

                app.UseDeveloperExceptionPage();
            }

            //DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            //defaultFilesOptions.DefaultFileNames.Clear();
            //defaultFilesOptions.DefaultFileNames.Add("Mypage.html");
            //app.UseDefaultFiles(defaultFilesOptions);
            //app.UseStaticFiles();
            //  FileServerOptions fileServer = new FileServerOptions();
            //  fileServer.DefaultFilesOptions.DefaultFileNames.Clear();
            //  fileServer.DefaultFilesOptions.DefaultFileNames.Add("Mypage.html");
            ////  app.UseFileServer(fileServer);
           // app.UseMvc();
            app.UseRouting();

            //app.Use(async (context, next) =>
            //{
            //    logger.LogInformation("MW1: Incoming Request");
            //    await next();
            //    logger.LogInformation("MW1: Outgoing Response");
            //});

            //app.Use(async (context, next) =>
            //{
            //    logger.LogInformation("MW2: Incoming Request");
            //    await next();
            //    logger.LogInformation("MW2: Outgoing Response");
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("MW3: Request handled and response produced");
            //    logger.LogInformation("MW3: Request handled and response produced");
            //});


            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    //await context.Response.WriteAsync("Hello World!");
                //    //await context.Response.WriteAsync("Process Name:"+System.Diagnostics.Process.GetCurrentProcess().ProcessName);
                //    //  await context.Response.WriteAsync(" MyKey =" + Configuration["MyKey"]);

                //   // throw new Exception("Some error processing the request");
                //    await context.Response.WriteAsync("Hello World!");



                //});
              
                endpoints.MapControllerRoute(
                  name: "default",
                 pattern: "{controller=Employee}/{action=Index}/{id?}");
            });
        }
    }
}

