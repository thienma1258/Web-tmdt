using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using Services.ImageServices;
using System.Drawing.Imaging;
using Microsoft.AspNetCore.Hosting;

namespace Services.Implement
{
    public class LocalImageServices: ImageService, IImageServices
     {
        public System.Drawing.Image resize(int Width, int Height, Image current)
        {
            try
            {
                int width, height;
                #region reckon size 
                if (current.Width > current.Height)
                {
                    width = Width;
                    height = Convert.ToInt32(current.Height * Height / (double)current.Width);
                }
                else
                {
                    width = Convert.ToInt32(current.Width * Width / (double)current.Height);
                    height = Height;
                }
                #endregion

                #region get resized bitmap 
                var canvas = new Bitmap(width, height);

                using (var graphics = Graphics.FromImage(canvas))
                {
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.DrawImage(current, 0, 0, width, height);
                }
                return canvas;
            }
            catch(Exception e)
            {
                throw e;
            }
            #endregion

        }
        public int defaultWidth=640;
        public int defaultHeight = 360;
        private IHostingEnvironment _env;
        public LocalImageServices(IHostingEnvironment hostingEnvironment)
        {
            _env = hostingEnvironment;
            defaultLocationImage = System.IO.Path.Combine(_env.WebRootPath,"uploadImage");
        }
        public string defaultLocationImage;
        public override string UploadImage(MemoryStream memoryStream, string imageName,out ImageErrorModel errorModel)
        {
            string imagePath = "";
            errorModel = new ImageErrorModel();
            try
            {
                Image image;
                if (IsValidImage(memoryStream, out image))
                {
                    if (image.Width < defaultWidth || image.Height < defaultHeight)
                    {
                        image = resize(defaultWidth, defaultHeight, image);
                    }

                }
                imagePath = defaultLocationImage +"/"+ imageName;
                errorModel.isSuccess = true;
                image.Save(imagePath,ImageFormat.Png);
                return imagePath;
            }
            catch(Exception e)
            {
                errorModel.exception = e;
                errorModel.message = "Không thể upload hình thành công";
                errorModel.ImageUploadEnum = Common.Enum.Log.ImageUploadEnum.Local;
                return "false";
            }

        }
    }
}
