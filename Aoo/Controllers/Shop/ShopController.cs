using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aoo.ViewModels.PM.ProductDetails;
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
        public async Task<IActionResult> MenShop(string men,string women)
        {
            if (Common.Enum.PM.TypeSexEnum.Male.ToString() == "Male")
            {

            }
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
            var pro = await ProductBLL.Find(id);
            if (pro == null)
                return NotFound();
            decimal price = 0;
            string listImage = null;
            List<string> listSize = new List<string>();
            foreach (var i in result)
            {
                listImage = i.listImages;
                price =i.Price;
                listSize.Add(i.Size.ToString());
            }
            LoadDetailsViewModel temp = new LoadDetailsViewModel()
            {
               
                ListSize=listSize,
                Color=color,
                Model=pro.Model,
                Price=price.ToString(),
                ListImage=listImage,
                Descrtiption=pro.Details
            };
            return View(temp);
        }
        public async Task<IActionResult> Specification(string id,string color)
        {
            var result = await ProductDetailsBLL.Get();
            var pro = await ProductBLL.Find(id);
            if (pro == null)
                return NotFound();
            decimal price = 0;
            List<string> listSize = new List<string>();
            foreach (var i in result)
            {
                price = i.Price;
                listSize.Add(i.Size.ToString());
            }
            LoadDetailsViewModel temp = new LoadDetailsViewModel()
            {
                ID = pro.ID,
                ListSize = listSize,
                Color = color,
                DefaultImages=pro.DefaultImage,
                Model = pro.Model,
                Price = price.ToString(),
                Descrtiption = pro.Details

            };
            return View(temp);

        }
        public IActionResult CartItem()
        {
            return View();
        }
    }
}