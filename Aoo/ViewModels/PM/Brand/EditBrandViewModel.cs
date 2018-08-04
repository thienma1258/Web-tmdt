﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.ViewModels.PM.Brand
{
    public class EditBrandViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public IFormFile DefaultImage { get; set; }
        [MaxLength(80)]
        [MinLength(5)]
        [Required]
        [DisplayName(" Mô tả:Chọn Ảnh Muốn Thay Đổi")]
        public string Description { get; set; }

    }
}