using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.App_start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(ref IApplicationBuilder app)
        {
            
            app.UseMvc(routes =>
            {
            routes.MapRoute(
            name: "default_route",
            template: "{controller}/{action}/{id?}",
            defaults: new { controller = "Home", action = "Index" });
                    
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default_route",
                template: "{controller}/{action}/{id?}",
                defaults: new { controller = "Shop", action = "MenShop" });

            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default_route",
                template: "{controller}/{action}/{id?}",
                defaults: new { controller = "Shop", action = "Detail" });

            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default_route",
                template: "{controller}/{action}/{id?}",
                defaults: new { controller = "Admin", action = "Admin" });

            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default_route",
                template: "{controller}/{action}/{id?}",
                defaults: new { controller = "Admin/PM", action = "Index" });

            });
        }
    }
}
