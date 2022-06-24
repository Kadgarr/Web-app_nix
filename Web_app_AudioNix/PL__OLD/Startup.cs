using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BL.Mapping;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace PL
{
    public class Task
    {
        public string Topic { get; set; }
        public string Purpose { get; set; }
        public int Hours { get; set; }
    }
    public class Startup
    {
        public IConfiguration AppConfiguration { get; set; }
        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("task.json").AddJsonFile("task2.json");
            AppConfiguration = builder.Build();

            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
         
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //если проект в разработке
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
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


            var task = new Task();
            AppConfiguration.Bind(task);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"Topic: {task.Topic}; Purpose: {task.Purpose}; Hours:{task.Hours}");
            });

        }
    }
}
