using Aoo.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo
{
    public class RequestSetOptionsMiddleware
    {
        private readonly RequestDelegate _next;
     

        public RequestSetOptionsMiddleware(
            RequestDelegate next)
        {
            _next = next;
         
        }

        public async Task Invoke(HttpContext httpContext)
        {
            bool check=Utils.IsMobilePhone(ref httpContext);
            await _next(httpContext);
        }
    }
    public class RequestSetOptionsStartupFilter : IStartupFilter
    {
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return builder =>
            {
                builder.UseMiddleware<RequestSetOptionsMiddleware>();
                next(builder);
            };
        }
    }
}
