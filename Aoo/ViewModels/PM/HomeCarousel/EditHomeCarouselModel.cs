using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.ViewModels.PM.HomeCarousel
{
    public class EditHomeCarouselModel
    {
        public string ID { get; set; }
        [Required]
        public IFormFile ImagePath { get; set; }
        [Required]
        [DisplayName("Mô tả")]
        public string Description { get; set; }
        [Required]
        public int OrderIndex { get; set; }
        public bool IsHiding { get; set; }
    }
}
