using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.ImageServices;

namespace Aoo.Controllers
{
    public class BaseController : Controller
    {
        public string BASE_ADMIN_URL = "~/Views/Admin/";
        public readonly IImageServices ImageServices;
        public int numberPerPage = 6;

        public BaseController( IImageServices imageServices)
        {
            this.ImageServices = imageServices;
        }
        protected int TotalPage(int totalCout)
        {
            int page = totalCout/ numberPerPage;
            if (totalCout % numberPerPage != 0)
                page++;
            return page;
        }

        protected string UploadImage(IFormFile file, ref ImageErrorModel imageErrorModel)
        {
            MemoryStream memoryStream = new MemoryStream();
             file.CopyTo(memoryStream);
             string ImagePath = this.ImageServices.UploadImage(memoryStream, file.FileName, out imageErrorModel);
            return ImagePath;
        }
        public List<string> UploadListImage(List<IFormFile> listfile, ref List<ImageErrorModel> imageErrorModels)
        {
            List<string> ListImagePath = new List<string>();
            for(int i = 0; i < listfile.Count; i++)
            {
                ImageErrorModel imageErrorModel=new ImageErrorModel();
                string ImagePath=UploadImage(listfile[i], ref imageErrorModel);
                imageErrorModels.Add(imageErrorModel);
                ListImagePath.Add(ImagePath);
            }
            return ListImagePath;
        }   

    }
}