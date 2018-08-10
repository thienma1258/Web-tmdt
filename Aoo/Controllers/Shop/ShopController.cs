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
        private readonly IProductDetailsBLL ProductDetailsBLL;
        private readonly IMainGroupBLL MainGroupBLL;
        private readonly ISubGroupBLL SubGroupBLL;
        public ShopController(IProductBLL productBLL, IImageServices imageServices, IMainGroupBLL mainGroupBLL, ISubGroupBLL subGroupBLL, IProductDetailsBLL productDetailsBLL):base(imageServices)
        {
            ProductBLL = productBLL;
            MainGroupBLL = mainGroupBLL;
            SubGroupBLL = subGroupBLL;
            ProductDetailsBLL = productDetailsBLL;
        }
        public async Task<IActionResult> MenShop()
        {
            return View(await ProductBLL.Get(filter:p=>p.SubGroup.MainGroup.TypeSex==Common.Enum.PM.TypeSexEnum.Male));
        }
        public async Task<IActionResult> WomenShop()
        {
            return View(await ProductBLL.Get(filter: p => p.SubGroup.MainGroup.TypeSex == Common.Enum.PM.TypeSexEnum.Female));
        }
        public async Task<IActionResult> ShopAll()
        {
            return View(await ProductBLL.Get());
        }
        public async Task<IActionResult> Detail(string id, string color)
        {
            var result = await ProductDetailsBLL.Get(filter: p => p.ProductID == id && p.TypeColor.ToString() == color);
            return View(result);
        }
        public IActionResult CartItem()
        {
            return View();
        }
    }
}