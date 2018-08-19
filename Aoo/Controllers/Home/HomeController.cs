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

        public HomeController(IViewRenderService viewRenderService, IBrandBLL brandBLL, IHomeSliderBLL homeSliderBLL,
            IImageServices imageServices
            , ISubGroupBLL subGroupBLL,
            ICategoryBLL categoryBLL,
            IProductDetailsBLL productDetailsBLL,
            IProductBLL productBLL
            ) : base(imageServices)
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


        [HttpGet("tim-kiem")]
        public async Task<IActionResult> Search(int page=1,string Search = null)
        {
            IEnumerable<Product> listProduct=null;
            if (Search != null)
            {
                listProduct = await productBLL.Get(ViewHelpers.NumberPerPageFront, page, filter: p => p.Model.Contains(Search), orderBy: p => p.OrderByDescending(product => product.EditedDate));
                ViewBag.page = page;
                int totalCount = productBLL.Cout(p => p.Model.Contains(Search));
                ViewBag.totalpage =ViewHelpers.TotalPage(totalCount,ViewHelpers.NumberPerPageFront);
            }
            return View("~/Views/Shop/ShopAll.cshtml", listProduct);

        }

        [HttpGet("/{urlType:regex(^(((?!images).)|((?!\\s)))+$)}")]
        public async Task<IActionResult> Seo(string urlType = null, int page = 1)
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
                ViewBag.Description = objBrand.MetaDescription;
                ViewBag.Image = objBrand.DefaultImage;
                return PartialView("~/Views/Component/BrandComponent.cshtml", objBrand);
            }
            #endregion
            #region Subgroup
            SubGroup objSubGroup = this.subGroupBLL.SearchByUrl(urlType);
            if (objSubGroup != null)
            {
                ViewBag.Title = objSubGroup.MetaTitle;
                ViewBag.Name = objSubGroup.Name;
                ViewBag.Keyword = objSubGroup.MetaDescription;
                ViewBag.Description = objSubGroup.MetaDescription;
                ViewBag.Image = objSubGroup.DefaultImage;

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
                ViewBag.Description = objCategory.MetaDescription;
                ViewBag.Image = objCategory.DefaultImage;

                return PartialView("~/Views/Component/CategoryComponent.cshtml", objCategory);

            }

            #endregion
            //
            return NotFound();
        }
        [HttpGet("/{urlSubgroup:regex(^((?!images).)+$)}/{name}/{color:regex(White|Red|Blue|Black)?}")]
        public async Task<IActionResult> Detail(string urlSubgroup = null, string name = null, string color = null)
        {
           
            IEnumerable<ProductDetails> result;
            var pro = productBLL.SearchByUrl(name);
            if (pro == null)
                return NotFound();
            var spe = pro.Specification;
            result = await productDetailsBLL.Get(filter: p => p.ProductID==pro.ID);
            string Color=null;
            if (color != null)
            {
                Color = color;
                result = result.Where(p => p.TypeColor.ToString() == color);
            }
            else if (result.Count() > 0)
            {
                var firstProductDetails = result.FirstOrDefault();
                Color = firstProductDetails.TypeColor.ToString();
                result = result.Where(p => p.TypeColor == firstProductDetails.TypeColor).ToList();
            }
            decimal price = pro.Price;
            //string IDtemp = id;
            List<string> listSize = new List<string>();
            List<string> listColor = new List<string>();
            List<string> listIdDetail = new List<string>();
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
                    listIdDetail.Add(i.ID);
                }


            }
            LoadDetailsViewModel temp = new LoadDetailsViewModel()
            {
                ListIDDetails = listIdDetail,
                ListSize = listSize,
                ID = pro.ID,
                Color = Color,
                DefaultImages = pro.DefaultImage,
                Model = pro.Model,
                ListImage = listImage,
                ListColor = listColor,
                Price = price == 0 ? "Chưa có hàng" : price.ToString(),
                Descrtiption = pro.Details,
                Specification = pro.Specification,
                IsAllowFacebookComment = pro.IsAllowComment,
                Quantity = 0,
                CurrentSize = "chua co",
                ImagePath = pro.DefaultImage
               
            };
            ViewBag.Title = pro.MetaTitle;
            if(color!=null)
                ViewBag.Name = pro.Model + "-" + color;
            else
                ViewBag.Name = pro.Model;

            ViewBag.Keyword = pro.MetaDescription;
            ViewBag.Description = pro.MetaDescription;
            ViewBag.Image = pro.DefaultImage;

            return View("~/Views/Shop/Detail.cshtml", temp);
        }
        //[HttpGet("/{urlSubgroup}/{name}")]
        //public async Task<IActionResult> Specification(string urlSubgroup=null,string name=null)
        //{
        //    if (name == "Not-found" || name == null || name == "undefined")
        //        return null;
        //    //choose default image if have
        //    var pro = this.productBLL.SearchByUrl(name);
        //    string listImage = null;
        //    var result = await this.productDetailsBLL.Get(filter:p=>p.ProductID==pro.ID);

        //    if (pro == null)
        //        return NotFound();
        //    decimal price = 0;
        //    string SelectedColor = null;
        //    List<string> listSize = new List<string>();
        //    List<string> listColor = new List<string>();
        //    if (result.Count() > 0)
        //    {
        //        var selectedColor = result.FirstOrDefault().TypeColor;
        //        foreach (var i in result)
        //        {
        //            if (listColor.FirstOrDefault(p => p == i.TypeColor.ToString()) == null)
        //            {
        //                listColor.Add(i.TypeColor.ToString());
        //            }
        //        }

        //            result = result.Where(p => p.TypeColor == selectedColor).ToList();
        //        foreach (var i in result)
        //        {

        //            listImage += i.listImages;
        //            price = i.Price;
        //            listSize.Add(i.Size.ToString());
        //        }
        //        SelectedColor = selectedColor.ToString();

        //    }



        //    LoadDetailsViewModel temp = new LoadDetailsViewModel()
        //    {
        //        ID = pro.ID,
        //        DefaultImages = pro.DefaultImage,
        //        Model = pro.Model,
        //        ListImage= listImage,
        //        ListSize= listSize,
        //        Price = price==0?"Chưa có hàng":price.ToString(),
        //        Descrtiption = pro.Details,
        //        IsAllowFacebookComment = pro.IsAllowComment

        //    };
        //    return View("~/Views/Shop/Detail.cshtml", temp);

        //}
    }
}
