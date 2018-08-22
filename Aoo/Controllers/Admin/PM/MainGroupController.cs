using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Aoo.ViewModels.PM.MainGroup;
using BLL;
using BLL.BLL.PM;
using DAL.Model.PM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.ImageServices;

namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]/[action]")]
    [Area("PM")]
    [Authorize]
    public class MainGroupController : BaseController
    {
        private readonly IMainGroupBLL MainGroupBLL;

        public MainGroupController(IMainGroupBLL maingroupdBLL, IImageServices imageServices) : base(imageServices)
        {
            MainGroupBLL = maingroupdBLL;
        } 
        public async Task<IActionResult> Index(int page=1)
        {

            ViewBag.currentPage = page;
            ViewBag.totalPage = TotalPage(MainGroupBLL.Cout());
            return View(await MainGroupBLL.Get(numberPerPage, page, orderBy: p => p.OrderByDescending(x => x.EditedDate)));
        }

        public async Task<IActionResult> AddMainGroup()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddMainGroup(AddMainGroupViewModel addMainGroupViewModel)
        {
            if (ModelState.IsValid)
            {
                ImageErrorModel imageErrorModel = new ImageErrorModel();
                string ImagePath = UploadImage(addMainGroupViewModel.DefaultImage, ref imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    MainGroup mainGroup = new MainGroup()
                    {
                        Name = addMainGroupViewModel.Name,
                        DefaultImage = ImagePath,
                        Description = addMainGroupViewModel.Description,
                        TypeSex=addMainGroupViewModel.TypeSex,
                        

                    };
                    await MainGroupBLL.Add(mainGroup);
                    return RedirectToAction("Index");
                }
            }

            return View();
        }
        public async Task<IActionResult> EditMainGroup( string id)
        {
            //chưa xử lý code
            MainGroup objmaingroup = await this.MainGroupBLL.Find(id);
            ViewModels.PM.MainGroup.EditMainGroupViewModel editViewMainGroupModel = new ViewModels.PM.MainGroup.EditMainGroupViewModel
            {
                ID = objmaingroup.ID,
                Name = objmaingroup.Name,
                Description = objmaingroup.Description,
                TypeSex= objmaingroup.TypeSex,
                OldImage = objmaingroup.DefaultImage

            };
            return View(editViewMainGroupModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditMainGroup(ViewModels.PM.MainGroup.EditMainGroupViewModel editViewMainGroupModel)
        {
            ImageErrorModel imageErrorModel = new ImageErrorModel();
            string ImagePath=null;
            if (editViewMainGroupModel.DefaultImage == null)
            {
                ImagePath = editViewMainGroupModel.OldImage;
                
            }
            else
            {
                ImagePath = UploadImage(editViewMainGroupModel.DefaultImage, ref imageErrorModel);
            }
            if (ModelState.IsValid)
            {
                    MainGroup objmaingroup = await this.MainGroupBLL.Find(editViewMainGroupModel.ID);
                    objmaingroup.Description = editViewMainGroupModel.Description;
                    objmaingroup.Name = editViewMainGroupModel.Name;
                    objmaingroup.DefaultImage = ImagePath;
                    objmaingroup.TypeSex = editViewMainGroupModel.TypeSex;
                    await MainGroupBLL.Update(objmaingroup);
                    return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(string id)
        {
            var isDelete = await MainGroupBLL.Delete(id);
            if (isDelete)
            {
                return Json(new { success = "true" });

            }
            return Json(new { success = "false" });
        }
    }
}