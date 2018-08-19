using BLL;
using BLL.BLL.Log;
using BLL.BLL.Log.Implement;
using BLL.BLL.PM;
using BLL.BLL.PM.Implement;
using BLL.BLL.System;
using BLL.BLL.System.Implement;
using DAL.Model.PM;
using DAL.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
            services.AddTransient<IHomeSliderBLL, HomeSliderBLL>();
            services.AddTransient<IDistrictBLL, DistrictBLL>();
            services.AddTransient<IProvinceBLL, ProvinceBLL>();
            services.AddTransient<IHomeCarouselBLL, HomeCarouselBLL>();
            services.AddTransient<ICategoryBLL, CategoryBLL>();
            services.AddTransient<IMainGroupBLL, MainGroupBLL>();
            services.AddTransient<ISubGroupBLL, SubGroupBLL>();
            services.AddTransient<IProductBLL, ProductBLL>();
            services.AddTransient<IUserBLL, UserBLL>();
            services.AddTransient<IErrorLogsBLL, ErrorLogsBLL>();
            services.AddTransient<IProductDetailsBLL, ProductDetailsBLL>();
            services.AddTransient<ISystem_User_PermissionBLL, System_User_Permission_BLL>();
            services.AddTransient<ITransportTypeBLL, TransportTypeBLL>();
            services.AddTransient<ITransportPriceBLL, TransportPriceBLL>();
            services.AddTransient<ISubscribeEmailBLL, SubscribeEmailBLL>();
        }
    }
}

       
