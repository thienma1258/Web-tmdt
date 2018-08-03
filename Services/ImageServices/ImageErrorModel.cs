﻿using System;
using System.Collections.Generic;
using System.Text;
using Common.Enum.Log;

namespace Services.ImageServices
{
   public class ImageErrorModel
    {
        public Exception exception;
        public string message;
        private Common.Enum.Log.ImageUploadEnum imageUploadEnum;
        public bool isSuccess;
        public ImageUploadEnum ImageUploadEnum { get => imageUploadEnum; set => imageUploadEnum = value; }
    }
}
