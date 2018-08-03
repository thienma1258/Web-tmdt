using Services.ImageServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Services
{
    public abstract class ImageService:IImageServices
    {
        public  bool IsValidImage(MemoryStream ms,out Image image)
        {
            image = null;
            try
            {
                    image=Image.FromStream(ms);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }
        public abstract string UploadImage(MemoryStream bytes, string imageName, out ImageErrorModel errorModel);
    }
}
