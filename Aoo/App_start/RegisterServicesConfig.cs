﻿using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.App_start
{
    public class RegisterServicesConfig
    {
        public static void RegisterServices(ref IServiceCollection services)
        {
            services.AddTransient<IImageServices, LocalImageServices>();
        }
    }
}