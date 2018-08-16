using DAL.Model.PM;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.ViewModels.PM
{
    public class AddProductViewModel
    {
        [Required]
        [MinLength(5)]
        public string Model { get; set; } = string.Empty;
        public bool isOnlineOnly { get; set; } = false;
        public int StockMin { get; set; } = 0;
        public decimal DefauftPrice { get; set; }
        [Required]
        public IFormFile DefaultImage { get; set; }
        [Required]
        public string Details { get; set; }
        //public string LadingPage { get; set; }
        //public virtual ICollection<ProductDetails> ListProductDetails { get; set; }
        //adidas nike
        public string Specification { get; set; }
        [Required]
        public string Brand { get; set; }
      
        public string Category { get; set; }
        //nganh hang chinh giay dep tat
        public string MainGroup { get; set; }
        // giay the thao giay công so, giay em be
       
        public string SubGroup { get; set; }
        [Required]
        public bool IsAllowComment { get; set; }
        [Required] 
        public decimal Price { get; set; }
        public string MetaTitle { get; set; }
        //public string MetaKey { get; set; }
        public string MetaDescription { get; set; }
    }
}
