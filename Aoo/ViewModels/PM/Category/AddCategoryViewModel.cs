using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.ViewModels.PM.Category
{
    public class AddCategoryViewModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public IFormFile DefaultImage { get; set; }
        [MinLength(5)]
        [Required]
        [DisplayName(" Mô tả:")]
        public string Description { get; set; }
    }
}
