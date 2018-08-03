using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Aoo.ViewModels.PM.MainGroup;
using BLL;
using DAL.Model.PM;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.ImageServices;

namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]/[action]")]
    [Area("PM")]
    public class MainGroupController : Controller
    {
        private readonly IGenericBLL<MainGroup, string> MainGroupBLL;
        public readonly IImageServices ImageServices;
        public MainGroupController(IGenericBLL<MainGroup, string> maingroupdBLL, IImageServices imageServices)
        {
            MainGroupBLL = maingroupdBLL;
            this.ImageServices = imageServices;
        }
        public async Task<IActionResult> Index()
        {
            return View(await MainGroupBLL.Get(6));
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
                ImageErrorModel imageErrorModel;
                MemoryStream memoryStream = new MemoryStream();
                await addMainGroupViewModel.DefaultImage.CopyToAsync(memoryStream);
                string ImagePath = this.ImageServices.UploadImage(memoryStream, addMainGroupViewModel.DefaultImage.FileName, out imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    MainGroup mainGroup = new MainGroup()
                    {
                        Name = addMainGroupViewModel.Name,
                        DefaultImage = ImagePath,
                        Description = addMainGroupViewModel.Description,
                        TypeSex=addMainGroupViewModel.TypeSex
                        
                    };
                    await MainGroupBLL.Add(mainGroup);
                }
            }

            return View();
        }
        public async Task<IActionResult> EditMainGroup( string id)
        {
            //chưa xử lý code
            MainGroup obj = await MainGroupBLL.Find(id);
            return View(obj);
        }
        public async Task<IActionResult> DeleteMainGroup( string id)
        {
            //chưa xử lý code
            MainGroup mainGroup = await MainGroupBLL.Find(id);
            return View();
        }
    }
}