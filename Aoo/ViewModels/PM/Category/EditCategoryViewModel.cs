using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.ViewModels.PM.Category
{
    public class EditCategoryViewModel
    {
        public string ID { get; set; }
        [Required]
        public string Name { get; set; }
        public IFormFile DefaultImage { get; set; }
        [MaxLength(80)]
        [MinLength(5)]
        [Required]
        [DisplayName(" Mô tả:")]
        public string Description { get; set; }
        public string OldImage { get; set; }
    }
}
