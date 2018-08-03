using BLL;
using BLL.BLL.PM;
using BLL.BLL.PM.Implement;
using DAL.Model.PM;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.App_start
{
    public class RegisterBLLConfig
    {
        public static void RegisterBLL(ref IServiceCollection services)
        {
            services.AddTransient<IGenericBLL<Brand,string>, BrandBLL>();
            services.AddTransient<IGenericBLL<Store, string>, StoreBLL>();
            services.AddTransient<IDistrictBLL, DistrictBLL>();
            services.AddTransient<IProvinceBLL, ProvinceBLL>();

        }
    }
}
