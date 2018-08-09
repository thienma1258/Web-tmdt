using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Aoo.ViewModels.PM.HomeSlider;
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
    public class HomeSliderController : BaseController
    {
        private readonly IHomeSliderBLL HomeSliderBLL;
        public HomeSliderController(IHomeSliderBLL homesliderBLL, IImageServices imageServices) : base(imageServices)
        {
            HomeSliderBLL = homesliderBLL;
        }
        public async Task<IActionResult> Index(int page=1)
        {
            ViewBag.currentPage = page;
            int totalcout = HomeSliderBLL.Cout();
            ViewBag.totalPage = TotalPage(totalcout);
            var ListHomeSlider = await HomeSliderBLL.Get(numberPerPage, page);
            //var ListBrandFilter = await BrandBLL.Get(filter: p => p.Name.Contains());
            return View(ListHomeSlider);
        }
        public async Task<IActionResult> AddHomeSlider()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddHomeSlider(ViewModels.PM.HomeSlider.AddHomeSliderModel addHomeSliderModel)
        {
            if (ModelState.IsValid)
            {
                ImageErrorModel imageErrorModel = new ImageErrorModel();
                string DefaultImage1 = UploadImage(addHomeSliderModel.ImagePath, ref imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    HomeSlider homeslider = new HomeSlider()
                    {
                        OrderIndex = addHomeSliderModel.OrderIndex,
                        ImagePath = DefaultImage1,
                        Description = addHomeSliderModel.Description

                    };
                    await HomeSliderBLL.Add(homeslider);
                    return RedirectToAction("Index");
                }
            }
            return View();

        }

        private string UploadImage(string imagePath, ref ImageErrorModel imageErrorModel)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> EditHomeSlider(string id)
        {
            HomeSlider objSlider = await this.HomeSliderBLL.Find(id);
            ViewModels.PM.HomeSlider.EditHomeSliderModel editHomeSliderModel = new ViewModels.PM.HomeSlider.EditHomeSliderModel
            {
                OrderIndex = objSlider.OrderIndex,
                ID = objSlider.ID,
                Description = objSlider.Description,
                OldImage = objSlider.ImagePath
            };
            return View(editHomeSliderModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditHomeSlider(ViewModels.PM.HomeSlider.EditHomeSliderModel editHomeSliderModel)
        {
            if (ModelState.IsValid)
            {

                ImageErrorModel imageErrorModel = new ImageErrorModel();
                string defaultImage1 = UploadImage(editHomeSliderModel.ImagePath, ref imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    HomeSlider objSlider = await this.HomeSliderBLL.Find(editHomeSliderModel.ID);
                    objSlider.Description = editHomeSliderModel.Description;
                    objSlider.OrderIndex = editHomeSliderModel.OrderIndex;
                    objSlider.ImagePath = defaultImage1;
                    await HomeSliderBLL.Update(objSlider);
                    return RedirectToAction("Index");
                }
            }

            return View();
        }
        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(string id)
        {
            var isDelete = await HomeSliderBLL.Delete(id);
            if (isDelete)
            {
                return Json(new { success = "true" });

            }
            return Json(new { success = "false" });
        }
    }
}
