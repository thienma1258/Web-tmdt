using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Aoo.ViewModels.PM.HomeCarousel;
using BLL;
using BLL.BLL.PM;
using DAL.Model.PM;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.ImageServices;
namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]/[action]")]
    [Area("PM")]
    public class HomeCarouselController : BaseController
    {
        private readonly IHomeCarouselBLL HomeCarouselBLL;
        public HomeCarouselController(IHomeCarouselBLL homecarouselBLL, IImageServices imageServices) : base(imageServices)
        {
            HomeCarouselBLL = homecarouselBLL;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            ViewBag.currentPage = page;
            int totalcout = HomeCarouselBLL.Cout();
            ViewBag.totalPage = TotalPage(totalcout);
            var ListHomeCarousel = await HomeCarouselBLL.Get(numberPerPage, page);
            //var ListBrandFilter = await BrandBLL.Get(filter: p => p.Name.Contains());
            return View(ListHomeCarousel);
        }
        public async Task<IActionResult> AddHomeCarousel()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddHomeCarousel(ViewModels.PM.HomeCarousel.AddHomeCarouselModel addHomeCarouselModel)
        {
            if (ModelState.IsValid)
            {
                ImageErrorModel imageErrorModel = new ImageErrorModel();
                string DefaultImage1 = UploadImage(addHomeCarouselModel.ImagePath, ref imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    HomeCarousel homecarousel = new HomeCarousel()
                    {
                        OrderIndex = addHomeCarouselModel.OrderIndex,
                        ImagePath = DefaultImage1,
                        Description = addHomeCarouselModel.Description,
                        IsHiding= addHomeCarouselModel.IsHiding
                       

                    };
                    await HomeCarouselBLL.Add(homecarousel);
                    return RedirectToAction("Index");
                }
            }
            return View();

        }
        public async Task<IActionResult> EditHomeCarousel(string id)
        {
            HomeCarousel objCarousel = await this.HomeCarouselBLL.Find(id);
            ViewModels.PM.HomeCarousel.EditHomeCarouselModel editHomeCarouselModel = new ViewModels.PM.HomeCarousel.EditHomeCarouselModel
            {
                OrderIndex = objCarousel.OrderIndex,
                ID = objCarousel.ID,
                Description = objCarousel.Description,
                IsHiding = objCarousel.IsHiding,
                OldImage = objCarousel.ImagePath

            };
            return View(editHomeCarouselModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditHomeCarousel(ViewModels.PM.HomeCarousel.EditHomeCarouselModel editHomeCarouselModel)
        {
            if (ModelState.IsValid)
            {

                ImageErrorModel imageErrorModel = new ImageErrorModel();
                string defaultImage1 = UploadImage(editHomeCarouselModel.ImagePath, ref imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    HomeCarousel objCarousel = await this.HomeCarouselBLL.Find(editHomeCarouselModel.ID);
                    objCarousel.Description = editHomeCarouselModel.Description;
                    objCarousel.OrderIndex = editHomeCarouselModel.OrderIndex;
                    objCarousel.ImagePath = defaultImage1;
                    objCarousel.IsHiding = editHomeCarouselModel.IsHiding;
                    await HomeCarouselBLL.Update(objCarousel);
                    return RedirectToAction("Index");
                }
            }

            return View();
        }
        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(string id)
        {
            var isDelete = await HomeCarouselBLL.Delete(id);
            if (isDelete)
            {
                return Json(new { success = "true" });

            }
            return Json(new { success = "false" });
        }
    }
}