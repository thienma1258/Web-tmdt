using Services.ImageServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Services
{
    public interface IImageServices
    {
        string UploadImage(byte[] bytes, string imageName,out ImageErrorModel errorModel);



    }
}
