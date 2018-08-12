using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aoo.ViewModels.PM.ProductDetails;
using BLL.BLL.PM;
using DAL.DataContext;
using DAL.Model.PM;
using Microsoft.AspNetCore.Mvc;
using Services;
using Microsoft.AspNetCore.Http;
using Aoo.Helpers;
namespace Aoo.Controllers.Shop
{
    [Route("[controller]/[action]")]
    public class ShopController : BaseController
    {
        private readonly IProductBLL ProductBLL;
        private readonly IProductDetailsBLL ProductDetailsBLL;
        private readonly IMainGroupBLL MainGroupBLL;
        private readonly ISubGroupBLL SubGroupBLL;
        private readonly IHttpContextAccessor HttpContextAccessor;
        public ShopController(IHttpContextAccessor httpContextAccessor, IProductBLL productBLL, IImageServices imageServices, IMainGroupBLL mainGroupBLL, ISubGroupBLL subGroupBLL, IProductDetailsBLL productDetailsBLL) : base(imageServices)
        {
            ProductBLL = productBLL;
            MainGroupBLL = mainGroupBLL;
            SubGroupBLL = subGroupBLL;
            ProductDetailsBLL = productDetailsBLL;
            HttpContextAccessor = httpContextAccessor;
        }
        public async Task<IActionResult> MenSHop()
        {
            IEnumerable<Product> listProducts = await ProductBLL.Get(filter: p => p.SubGroup.MainGroup.TypeSex == Common.Enum.PM.TypeSexEnum.Male || p.SubGroup.MainGroup.TypeSex == Common.Enum.PM.TypeSexEnum.All);

            return View(listProducts);
        }
        public async Task<IActionResult> WomenShop()
        {
            IEnumerable<Product> listProducts = await ProductBLL.Get(filter: p => p.SubGroup.MainGroup.TypeSex == Common.Enum.PM.TypeSexEnum.Female || p.SubGroup.MainGroup.TypeSex == Common.Enum.PM.TypeSexEnum.All);
            return View(listProducts);
        }
        public async Task<IActionResult> ShopAll()
        {
            return View(await ProductBLL.Get());
        }
        public async Task<IActionResult> Detail(string id, string color=null)
        {
            IEnumerable<ProductDetails> result;
            if (color != null)
                result = await ProductDetailsBLL.Get(filter: p => p.ProductID == id && p.TypeColor.ToString() == color);
            else
                result = await ProductDetailsBLL.Get(filter: p => p.ProductID == id);
            var pro = await ProductBLL.Find(id);
            if (pro == null)
                return NotFound();
            decimal price = 0;
            string IDtemp = id;
            List<string> listSize = new List<string>();
            List<string> listColor = new List<string>();
            string listImage = null;
            if (result.Count() > 0)
            {
                foreach (var i in result)
                {
                    if (listColor.FirstOrDefault(p => p == i.TypeColor.ToString()) == null)
                    {
                        listColor.Add(i.TypeColor.ToString());
                    }
                }
                var selectedColor = result.FirstOrDefault().TypeColor;
                result = result.Where(p => p.TypeColor == selectedColor).ToList();
                foreach (var i in result)
                {

                    listImage = listImage + "," + i.listImages;
                    price = i.Price;
                    listSize.Add(i.Size.ToString());
                }

            }
            LoadDetailsViewModel temp = new LoadDetailsViewModel()
            {
                ID = IDtemp,
                ListSize = listSize,
                Color = color,
                DefaultImages = pro.DefaultImage,
                Model = pro.Model,
                ListImage = listImage,
                ListColor = listColor,
                Price = price == 0 ? "Chưa có hàng" : price.ToString(),
                Descrtiption = pro.Details,
                IsAllowFacebookComment = pro.IsAllowComment
            };
            return View(temp);

            //return View();
        }
       
        //public async Task<IActionResult> Specification(string id)
        //{
        //    var result = await ProductDetailsBLL.Get(filter:p=>p.ProductID==id);
        //    var pro = await ProductBLL.Find(id);

        //    if (pro == null)
        //        return NotFound();
        //    decimal price = 0;
        //    foreach (var i in result)
        //    {
        //        price = i.Price;
        //    }
        //    List<string> listColor = new List<string>();
        //    foreach(var productdetail in result)
        //    {
        //        if (listColor.FirstOrDefault(p=>p==productdetail.TypeColor.ToString())==null)
        //        {
        //            listColor.Add(productdetail.TypeColor.ToString());
        //        }
        //    }
        //    LoadDetailsViewModel temp = new LoadDetailsViewModel()
        //    {
        //        ID = pro.ID,
        //        DefaultImages=pro.DefaultImage,
        //        ListColor= listColor,
        //        Model = pro.Model,
        //        Price = price==0?"Chua co hang":price.ToString(),
        //        Descrtiption = pro.Details

        //    };
        //    return View(temp);

        //}
        public IActionResult CartItem()
        {
            return View();
        }      
    }
}