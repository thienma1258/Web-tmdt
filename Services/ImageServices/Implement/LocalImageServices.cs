using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Services.ImageServices;
using Microsoft.AspNetCore.Hosting;
using System.Drawing;

namespace Services.Implement
{
    public class LocalImageServices: ImageService, IImageServices
     {
        public Image resize(int Width, int Height, Image current)
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
                    graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
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
        public int defaultWidth=720;
        public int defaultHeight = 480;
        private IHostingEnvironment _env;
        public string subRoot = "images";
        public LocalImageServices(IHostingEnvironment hostingEnvironment)
        {
            _env = hostingEnvironment;
            defaultLocationImage = System.IO.Path.Combine(Directory.GetCurrentDirectory()+"\\wwwroot\\", subRoot);
        }
        public string defaultLocationImage;
        public override string UploadImage(MemoryStream memoryStream, string imageName,out ImageErrorModel errorModel)
        {
            string imagePath = "";
            Logging.Logging logging = new Logging.Logging();

            errorModel = new ImageErrorModel();
            try
            {
                Image image=null;
                using (image = Image.FromStream(memoryStream))
                {
                        if (image.Width < defaultWidth || image.Height < defaultHeight)
                        {
                            image = resize(defaultWidth, defaultHeight, image);
                        }
                        imagePath = defaultLocationImage + "\\" + imageName;
                        image.Save(imagePath);
                        errorModel.isSuccess = true;
                        return "~/" + subRoot + "/" + imageName;
                    

                }
            }
            catch (Exception e)
            {
                errorModel.exception = e;
                errorModel.isSuccess = false;
                errorModel.message = "Không thể upload hình thành công";
                errorModel.ImageUploadEnum = Common.Enum.Log.ImageUploadEnum.Local;
                logging.ErrorLogs(errorModel.ToString());
                return "false";
            }

        }
        //ListUpLoadImage
      
        public override  bool DeleteImage(string ImageName, out ImageErrorModel errorModel)
        {
            errorModel = new ImageErrorModel();
            try
            {
                int startNameIndex = ImageName.LastIndexOf('/')+1;
                var _imageName = ImageName.Substring(startNameIndex, ImageName.Length - startNameIndex);
                string imagePath= defaultLocationImage+"\\"+ _imageName;
                return true;
            }
            catch (Exception e)
            {
                errorModel.exception = e;
                errorModel.message = "Không thể xóa";
                errorModel.ImageUploadEnum = Common.Enum.Log.ImageUploadEnum.Local;
                return false;
            }
        }
    }
}
