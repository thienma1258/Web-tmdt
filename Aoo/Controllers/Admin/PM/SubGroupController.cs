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
        private readonly IGenericBLL<SubGroup, string> SubGroupBLL;
        public SubGroupController(IGenericBLL<SubGroup, string> subGroupBLL, IImageServices imageServices, IMainGroupBLL MainGroupBLL) : base(imageServices)
        {
            SubGroupBLL = subGroupBLL;
            this.MainGroupBLL = MainGroupBLL;
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
                    subGroup.MainGroup =await  MainGroupBLL.Find(addSubGroupViewModel.MainGroup);
                    await SubGroupBLL.Add(subGroup);
                    return RedirectToAction("Index");
                }
               
            }
            return View();
        }
        public IActionResult EditSubGroup()
        {
            return View();
        }
        public IActionResult DeleteSubGroup()
        {
            return View();
        }
    }
}