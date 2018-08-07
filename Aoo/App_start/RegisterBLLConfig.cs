using BLL;
using BLL.BLL.PM;
using BLL.BLL.PM.Implement;
using DAL.Model.PM;
using DAL.Repository;
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
            services.AddTransient<IBrandBLL, BrandBLL>();
            services.AddTransient<IStoreBLL, StoreBLL>();
            services.AddTransient<IGenericBLL<HomeSlider, string>, HomeSliderBLL>();
            services.AddTransient<IDistrictBLL, DistrictBLL>();
            services.AddTransient<IProvinceBLL, ProvinceBLL>();
  			
  			services.AddTransient<ICategoryBLL, CategoryBLL>();
            services.AddTransient<IMainGroupBLL, MainGroupBLL>();
            services.AddTransient<ISubGroupBLL, SubGroupBLL>();
            services.AddTransient<IProductBLL, ProductBLL>();

        }
    }
}
