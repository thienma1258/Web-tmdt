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
        public  bool IsValidImage(byte[] bytes,out Image image)
        {
            image = null;
            try
            {
                using (MemoryStream ms = new MemoryStream(bytes))
                    image=Image.FromStream(ms);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }
        public abstract string UploadImage(byte[] bytes, string imageName, out ImageErrorModel errorModel);
    }
}
