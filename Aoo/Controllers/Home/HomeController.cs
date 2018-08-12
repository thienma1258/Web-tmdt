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

            if (urlType == "Not-found" || urlType == null || urlType == "undefined") 
                return null;
            ViewBag.html = "";
            ViewBag.page = page;
            if (urlType == null)
                return RedirectToAction("Error");
            //check Brand
            #region Brand
            Brand objBrand = this.brandBLL.SearchByUrl(urlType);
           
            if (objBrand != null)
            {
                ViewBag.Title = objBrand.MetaTitle;
                ViewBag.Name = objBrand.Name;
                ViewBag.Keyword = objBrand.MetaDescription;
                return PartialView("~/Views/Component/BrandComponent.cshtml",objBrand);
            }
            #endregion
            #region Subgroup
            SubGroup objSubGroup = this.subGroupBLL.SearchByUrl(urlType);
            if (objSubGroup != null)
            {
                ViewBag.Title = objSubGroup.MetaTitle;
                ViewBag.Name = objSubGroup.Name;
                ViewBag.Keyword = objSubGroup.MetaDescription;
                return PartialView("~/Views/Component/SubGroupComponent.cshtml", objSubGroup);

            }
            #endregion
            #region Categoryfilter
            Category objCategory = this.categoryBLL.SearchByUrl(urlType);
            if (objCategory != null)
            {
                ViewBag.Title = objCategory.MetaTitle;
                ViewBag.Name = objCategory.Name;
                ViewBag.Keyword = objCategory.MetaDescription;
                return PartialView("~/Views/Component/CategoryComponent.cshtml", objCategory);

            }

            #endregion
            //
            return NotFound();
        }
        [HttpGet("/{urlSubgroup}/{name}/{color}")]
        public async Task<IActionResult> Detail(string urlSubgroup=null,string name=null, string color=null)
        {
            if (name == "Not-found" || name == null || name == "undefined")
                return null;
            var result = await productDetailsBLL.Get(filter: p => p.Product.UrlFriendly == name && p.TypeColor.ToString().ToLower() == color.ToLower());
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
                Specification=pro.Specification,
                IsAllowFacebookComment = pro.IsAllowComment
               
            };
            ViewBag.Title = pro.MetaTitle;
            ViewBag.Name = pro.Model+"-"+ color;
            ViewBag.Keyword = pro.MetaDescription;
            return View("~/Views/Shop/Detail.cshtml",temp);
        }
        [HttpGet("/{urlSubgroup}/{name}")]
        public async Task<IActionResult> Specification(string urlSubgroup=null,string name=null)
        {
            if (name == "Not-found" || name == null || name == "undefined")
                return null;
            //choose default image if have
            var pro = this.productBLL.SearchByUrl(name);
            string listImage = null;
            var result = await this.productDetailsBLL.Get(filter:p=>p.ProductID==pro.ID);
           
            if (pro == null)
                return NotFound();
            decimal price = 0;
            string SelectedColor = null;
            List<string> listSize = new List<string>();
            List<string> listColor = new List<string>();
            if (result.Count() > 0)
            {
                var selectedColor = result.FirstOrDefault().TypeColor;
                foreach (var i in result)
                {
                    if (listColor.FirstOrDefault(p => p == i.TypeColor.ToString()) == null)
                    {
                        listColor.Add(i.TypeColor.ToString());
                    }
                }
            
                    result = result.Where(p => p.TypeColor == selectedColor).ToList();
                foreach (var i in result)
                {
                   
                    listImage += i.listImages;
                    price = i.Price;
                    listSize.Add(i.Size.ToString());
                }
                SelectedColor = selectedColor.ToString();

            }
            

         
            LoadDetailsViewModel temp = new LoadDetailsViewModel()
            {
                ID = pro.ID,
                DefaultImages = pro.DefaultImage,
                Model = pro.Model,
                ListImage= listImage,
                ListSize= listSize,
                Price = price==0?"Chưa có hàng":price.ToString(),
                Descrtiption = pro.Details,
                IsAllowFacebookComment = pro.IsAllowComment

            };
            return View("~/Views/Shop/Detail.cshtml", temp);

        }
    }
}
