using Imgur.API;
using Imgur.API.Authentication.Impl;
using Imgur.API.Endpoints.Impl;
using Imgur.API.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Services.ImageServices.Implement
{
    public  class ImagurUploadImage: IImageServices
    {
        string CLientId = "e3bf807a1f8c9e6";
        string ClientSecret = "38e30c2b68eaa973b1ad460db463a7718de435ec";
        public  string UploadImage(MemoryStream memoryStream, string imageName, out ImageErrorModel errorModel)
        {
            errorModel = new ImageErrorModel();
            try
            {
                var client = new ImgurClient(CLientId, ClientSecret);
                var endpoint = new ImageEndpoint(client);
                IImage image;
            
                image =  endpoint.UploadImageStreamAsync(memoryStream).GetAwaiter().GetResult();
                errorModel.isSuccess = true;
                return image.Link;
              
            }
            catch (ImgurException imgurEx)
            {
                errorModel.exception = imgurEx;
                errorModel.isSuccess = false;
                errorModel.message = "Không thể upload hình thành công";
                errorModel.ImageUploadEnum = Common.Enum.Log.ImageUploadEnum.Local;
                return "false";
            }
        }
    }
}
