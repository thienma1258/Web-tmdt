using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aoo.Models;
using DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using DAL.Model.PM;
using Services;
using BLL.BLL.PM.Implement;
using BLL.BLL.PM;
using Aoo.Helpers;
using Aoo.ViewModels.PM.ProductDetails;

namespace Aoo.Controllers
{
    public class HomeController : BaseController
    {
        
        private readonly IHomeSliderBLL HomeSliderBLL;

        private readonly IBrandBLL brandBLL;
        private readonly ISubGroupBLL subGroupBLL;
        private readonly ICategoryBLL categoryBLL;
        private readonly IViewRenderService viewRenderService;
        private readonly IProductDetailsBLL productDetailsBLL;
        private readonly IProductBLL productBLL;

        public HomeController(IViewRenderService viewRenderService, IBrandBLL brandBLL,IHomeSliderBLL homeSliderBLL,
            IImageServices imageServices
            , ISubGroupBLL subGroupBLL,
            ICategoryBLL categoryBLL,
            IProductDetailsBLL productDetailsBLL,
            IProductBLL productBLL
            ) :base(imageServices)
        {
            this.productBLL = productBLL;
            this.productDetailsBLL = productDetailsBLL;
            this.subGroupBLL = subGroupBLL;
            HomeSliderBLL = homeSliderBLL;
            this.categoryBLL = categoryBLL;
            this.viewRenderService = viewRenderService;
            this.brandBLL = brandBLL;
        }
        public async Task<IActionResult> Index()
        {
         
            return View(await HomeSliderBLL.Get());
        }
        
        

        public async Task<IActionResult> Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet("/{urlType}")]
        public async Task<IActionResult> Seo(string urlType=null,int page=1)
        {
            ViewBag.html = "";
            ViewBag.page = page;
            if (urlType == null)
                return RedirectToAction("Error");
            //check Brand
            #region Brand
            Brand objBrand = this.brandBLL.SearchByUrl(urlType);
           
            if (objBrand != null)
            {
                ViewBag.html = await viewRenderService.RenderToStringAsync("Component/BrandComponent", objBrand);
                ViewBag.Title = objBrand.MetaTitle;
                ViewBag.Name = objBrand.Name;
                ViewBag.Keyword = objBrand.MetaDescription;
                return View();
            }
            #endregion
            #region Subgroup
            SubGroup objSubGroup = this.subGroupBLL.SearchByUrl(urlType);
            if (objSubGroup != null)
            {
                ViewBag.html = await viewRenderService.RenderToStringAsync("Component/SubGroupComponent", objSubGroup);
                ViewBag.Title = objSubGroup.MetaTitle;
                ViewBag.Name = objSubGroup.Name;
                ViewBag.Keyword = objSubGroup.MetaDescription;
                return View();
            }
            #endregion
            #region Categoryfilter
            Category objCategory = this.categoryBLL.SearchByUrl(urlType);
            if (objCategory != null)
            {
                ViewBag.html = await viewRenderService.RenderToStringAsync("Component/CategoryComponent", objCategory);
                ViewBag.Title = objCategory.MetaTitle;
                ViewBag.Name = objCategory.Name;
                ViewBag.Keyword = objCategory.MetaDescription;
                return View();
            }

            #endregion
            //
            return NotFound();
        }
        [HttpGet("/{urlSubgroup}/{name}/{color}")]
        public async Task<IActionResult> Detail(string urlSubgroup,string name, string color)
        {

            var result = await productDetailsBLL.Get(filter: p => p.Product.UrlFriendly == name && p.TypeColor.ToString() == color);
            if (result.Count() == 0)
                return Redirect("/Not-found");
            var pro= this.productBLL.SearchByUrl(name);
            decimal price = 0;
            string listImage = null;
            List<string> listSize = new List<string>();
            foreach (var i in result)
            {
                listImage = i.listImages;
                price = i.Price;
                listSize.Add(i.Size.ToString());
            }
            LoadDetailsViewModel temp = new LoadDetailsViewModel()
            {
                ListSize = listSize,
                Color = color,
                Model = pro.Model,
                Price = price.ToString(),
                ListImage = listImage,
                Descrtiption = pro.Details,
                IsAllowFacebookComment = pro.IsAllowComment
               
            };
            ViewBag.Title = pro.MetaTitle;
            ViewBag.Name = pro.Model+"-"+ color;
            ViewBag.Keyword = pro.MetaDescription;
            return View("~/Views/Shop/Detail.cshtml",temp);
        }

    }
}
