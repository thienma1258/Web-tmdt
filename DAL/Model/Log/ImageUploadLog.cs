using Common.Enum.Log;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.Log
{
   public class ImageUploadLog
    {
        [Key]
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public string CreatedUser { get; set; }
        public ImageUploadEnum ImageUploadEnum { get; set; } = ImageUploadEnum.Local;
        public string Erros { get; set; }
        public string IsSuccess { get; set; }
        public string IdImage { get; set; }

    }
}
