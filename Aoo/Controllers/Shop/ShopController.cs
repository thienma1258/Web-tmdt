using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.BLL.PM;
using DAL.DataContext;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Aoo.Controllers.Shop
{
    [Route("[controller]/[action]")]
    public class ShopController : BaseController
    {
        private readonly IProductBLL ProductBLL;
        private readonly IMainGroupBLL MainGroupBLL;
        private readonly ISubGroupBLL SubGroupBLL;
        public ShopController(IProductBLL productBLL, IImageServices imageServices, IMainGroupBLL mainGroupBLL, ISubGroupBLL subGroupBLL):base(imageServices)
        {
            ProductBLL = productBLL;
            MainGroupBLL = mainGroupBLL;
            SubGroupBLL = subGroupBLL;
        }
        public async Task<IActionResult> MenShop()
        {

            return View(await ProductBLL.Get(filter:p=>p.SubGroup.MainGroup.TypeSex==Common.Enum.PM.TypeSexEnum.Male));
        }
        public IActionResult Detail()
        {
            return View();
        }
        public IActionResult CartItem()
        {
            return View();
        }
    }
}