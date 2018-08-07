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
    public class SubGroupController : BaseController
    {
        private readonly IMainGroupBLL MainGroupBLL;
        private readonly ISubGroupBLL SubGroupBLL;
        public SubGroupController(ISubGroupBLL subGroupBLL, IImageServices imageServices, IMainGroupBLL MainGroupBLL) : base(imageServices)
        {
            SubGroupBLL = subGroupBLL;
        }
        //public async Task<IEnumerable<MainGroup>> GetMainGroup()
        //{     
        //    var listMainGroup = await MainGroupBLL.Get(6);
        //    return listMainGroup;

        //}
        public async Task<IActionResult> Index()
        {
            return View(await SubGroupBLL.Get(6));
        }
        public async Task<IActionResult> AddSubGroup()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSubGroup(ViewModels.PM.SubGroup.AddSubGroupViewModel addSubGroupViewModel)
        {
            if (ModelState.IsValid)
            {
                ImageErrorModel imageErrorModel = new ImageErrorModel();
                string ImagePath = UploadImage(addSubGroupViewModel.DefaultImage, ref imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    SubGroup subGroup = new SubGroup()
                    {
                        Name = addSubGroupViewModel.Name,
                        DefaultImage = ImagePath,
                        Description = addSubGroupViewModel.Description,
                        TypeSex = addSubGroupViewModel.TypeSex,
                
                    };
                    subGroup.MainGroupID =addSubGroupViewModel.MainGroup;
                    await SubGroupBLL.Add(subGroup);
                    return RedirectToAction("Index");
                }
               
            }
            return View();
        }
        public async Task<IActionResult> EditSubGroup(string id)
        {
            //chưa xử lý code
            SubGroup objsubgroup = await this.SubGroupBLL.Find(id);
            ViewModels.PM.SubGroup.EditSubGroupViewModel editSubGroupModel = new ViewModels.PM.SubGroup.EditSubGroupViewModel
            {
                Name = objsubgroup.Name,
                Description = objsubgroup.Description,
                TypeSex = objsubgroup.TypeSex,

            };
            return View(objsubgroup);
        }
        [HttpPost]
        public async Task<IActionResult> EditSubGroup(ViewModels.PM.SubGroup.EditSubGroupViewModel editSubGroupViewModel)
        {
            if (ModelState.IsValid)
            {

                ImageErrorModel imageErrorModel = new ImageErrorModel();
                string ImagePath = UploadImage(editSubGroupViewModel.DefaultImage, ref imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    //SubGroup subGroup = new SubGroup()
                    
                    SubGroup objsubgroup = await this.SubGroupBLL.Find(editSubGroupViewModel.ID);
                    objsubgroup.Description = editSubGroupViewModel.Description;
                    objsubgroup.Name = editSubGroupViewModel.Name;
                    objsubgroup.DefaultImage = ImagePath;
                    objsubgroup.TypeSex = editSubGroupViewModel.TypeSex;
                    await SubGroupBLL.Update(objsubgroup);
                    return RedirectToAction("Index");
                };


            }
            return View();
        }
        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(string id)
        {
            var isDelete = await SubGroupBLL.Delete(id);
            if (isDelete)
            {
                return Json(new { success = "true" });

            }
            return Json(new { success = "false" });
        }
    }
}