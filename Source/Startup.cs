using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Source.Models;
using Source.Models.DBF;

namespace Source
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
            services.AddDbContext<admin_hifivetestContext>(options => options
             .UseSqlServer(Configuration["ConnectionDatabase:DatabaseCompany:ConnectionString"]));
            services.AddTransient<IRepository, EFRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "AdminDichVu",
                template: "admin/dich-vu",
                defaults: new { controller = "Admin",action="DichVu" });
                routes.MapRoute(
                name: "AdminNhomDuAn",
                template: "admin/nhom-du-an",
                defaults: new { controller = "Admin", action = "NhomDuAn" });
                routes.MapRoute(
                name: "AdminTinTuc",
                template: "admin/tin-tuc",
                defaults: new { controller = "Admin", action = "TinTuc" });
                routes.MapRoute(
                name: "AdminLoaiTinTuc",
                template: "admin/loai-tin-tuc",
                defaults: new { controller = "Admin", action = "LoaiTinTuc" });
                routes.MapRoute(
                name: "Admin",
                template: "admin/home",
                defaults: new { controller = "Admin", action = "Index" });
                routes.MapRoute(
                name: "default",
                template: "{controller=Product}/{action=Index}/{id?}");
            });
        }
    }
}
