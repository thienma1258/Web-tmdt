using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Aoo.Models;
using Aoo.Services;
using Aoo.App_start;
using Aoo.Helpers;
using Microsoft.AspNetCore.Mvc.Razor;
using DAL.DataContext;
using DAL.Model;
using DAL;
using CacheHelpers;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Services.EmailServices;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.Server.IISIntegration;

namespace Aoo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddOptions();
            //        services.AddDbContext<ShopContext>(


            services.AddDbContext<ShopContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")
                 , sqlServerOptions => sqlServerOptions.CommandTimeout(60))
                );

            services.AddIdentity<System_User, IdentityRole>()
                .AddEntityFrameworkStores<ShopContext>()
                .AddDefaultTokenProviders();
            // Add application services.
            services.Configure<RazorViewEngineOptions>(o =>
            {
                o.ViewLocationExpanders.Add(new CustomViewEngine());
            });

            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
            });

            services.AddMemoryCache();
            //  services.AddTransient<IStartupFilter, RequestSetOptionsStartupFilter>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDataCache, CacheMemory>();
            RegisterBLLConfig.RegisterBLL(ref services);
            RegisterServicesConfig.RegisterServices(ref services);
         

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 7;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 6;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                // If the LoginPath isn't set, ASP.NET Core defaults 
                // the path to /Account/Login.
                options.LoginPath = "/Admin/Login";
                // If the AccessDeniedPath isn't set, ASP.NET Core defaults 
                // the path to /Account/AccessDenied.
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.AddMvc().AddJsonOptions(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            //Configuration = builder.Build();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
        //        var options = new RewriteOptions()
        //.AddRedirectToHttps(StatusCodes.Status301MovedPermanently, 443);
        //        app.UseRewriter(options);

                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();

                app.UseExceptionHandler("/Home/Error");
            }


            app.UseStaticFiles();
         //   app.UseMiddleware<IgnoreRouteMiddleware>();
            app.UseAuthentication();
            app.UseSession();
            RouteConfig.RegisterRoutes(ref app);

        }
    }
}
public class IgnoreRouteMiddleware
{

    private readonly RequestDelegate next;

    // You can inject a dependency here that gives you access
    // to your ignored route configuration.
    public IgnoreRouteMiddleware(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        if (context.Request.Path.HasValue &&
            context.Request.Path.Value.Contains("Not-found"))
        {

            context.Response.StatusCode = 404;

            Console.WriteLine("Ignored!");

            return;
        }

        await next.Invoke(context);
    }
}