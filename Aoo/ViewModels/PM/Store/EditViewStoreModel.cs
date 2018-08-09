using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Aoo.ViewModels.PM.Store
{
    public class EditViewStoreModel
    {

        public string ID { get; set; }
        public string Address { get; set; }
        [Required]
        public string NameStore { get; set; }
        [Required]
        public IFormFile DefaultImage { get; set; }
        public string DefaultImageString { get; set; }
        [MaxLength(80)]
        [MinLength(5)]
        [Required]
        [DisplayName("Mô tả")]
        public string Description { get; set; }
        
    }
}
