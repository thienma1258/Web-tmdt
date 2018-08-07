using Services.ImageServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Services
{
    public interface IImageServices
    {
        string UploadImage(MemoryStream memoryStream, string imageName,out ImageErrorModel errorModel);
       




    }
}
