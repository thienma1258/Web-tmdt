using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Services.ImageServices.Implement
{
    public class ClouddinaryUploadImage: IImageServices
    {
        public string apikey = "554245423642471";
        public string apiSecret = "ykTM5MKjZH24L1IuLC01vQ1M2Ec";
        Cloudinary cloudinary;
        public ClouddinaryUploadImage()
        {
            Account account = new Account(
  "pedagogy",
 apikey,
  apiSecret);

             cloudinary = new Cloudinary(account);
        }
     
        public string UploadImage(MemoryStream memoryStream, string imageName, out ImageErrorModel errorModel)
        {
            errorModel = new ImageErrorModel();
            try
            {
            
                Stream stream = new MemoryStream(memoryStream.ToArray());
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(imageName, stream),
                    PublicId = imageName

                };
                var uploadResult = cloudinary.Upload(uploadParams);
                var link = uploadResult.Uri.AbsoluteUri;
                errorModel.isSuccess = true;
                return link;
            }
            catch (Exception imgurEx)
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
