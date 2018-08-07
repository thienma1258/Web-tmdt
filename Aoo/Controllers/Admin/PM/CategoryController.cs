using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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

    public class CategoryController : BaseController
    {
        private readonly  ICategoryBLL CategoryBLL;
        public CategoryController(ICategoryBLL categoryBLL, IImageServices imageServices): base(imageServices)        {
            CategoryBLL = categoryBLL;
                  }


        public async Task<IActionResult> Index(int page = 1)
        {
            ViewBag.currentPage = page;
            ViewBag.totalPage = TotalPage(CategoryBLL.Cout());
            return View(await CategoryBLL.Get(numberPerPage, page));
        }

        public async Task<IActionResult> AddCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddCategory(ViewModels.PM.Category.AddCategoryViewModel addCategoryViewModel)
        {
            if (ModelState.IsValid)
            {

				ImageErrorModel imageErrorModel = new ImageErrorModel();
                string ImagePath = UploadImage(addCategoryViewModel.DefaultImage, ref imageErrorModel);                if (imageErrorModel.isSuccess)
                {
                    Category category = new Category()
                    {
                        Name = addCategoryViewModel.Name,
                        DefaultImage = ImagePath,
                        Description = addCategoryViewModel.Description

                    };
                    await CategoryBLL.Add(category);
                    return RedirectToAction("Index");
                }
            }
            return View();

        }
        public async Task<IActionResult> EditCategory(string id)
        {
            //chưa xử lý code
            Category objcategory = await this.CategoryBLL.Find(id);
            ViewModels.PM.Category.EditCategoryViewModel editcategory = new ViewModels.PM.Category.EditCategoryViewModel
            {
                ID = objcategory.ID,
                Name = objcategory.Name,
                Description = objcategory.Description,
                OldImage = objcategory.DefaultImage

            };
            return View(editcategory);
        }
        [HttpPost]
        public async Task<IActionResult> EditCategory(ViewModels.PM.Category.EditCategoryViewModel editcategory)
        {
            if (ModelState.IsValid)
            {

                ImageErrorModel imageErrorModel = new ImageErrorModel();
                string ImagePath = UploadImage(editcategory.DefaultImage, ref imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    Category objcategory = await this.CategoryBLL.Find(editcategory.ID);
                    objcategory.Description = editcategory.Description;
                    objcategory.Name = editcategory.Name;
                    objcategory.DefaultImage = ImagePath;
                    await CategoryBLL.Update(objcategory);
                    return RedirectToAction("Index");
                }

            }
            return View();
        }
        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(string id)
        {
            var isDelete = await CategoryBLL.Delete(id);
            if (isDelete)
            {
                return Json(new { success = "true" });

            }
            return Json(new { success = "false" });
        }
    }
}