using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.ViewModels.PM.Product
{
    public class EditProductViewModel
    {
        public string ID { get; set; }
        public string Model { get; set; } = string.Empty;
        public bool isOnlineOnly { get; set; } = false;
        public int StockMin { get; set; } = 0;
        public IFormFile DefaultImage { get; set; }
        public string Specification { get; set; }
        public decimal DefauftPrice { get; set; }
        public string OldSpecification { get; set; }
        public string Details { get; set; }
        //adidas nike
        public string Brand { get; set; }
        public string Category { get; set; }
        //nganh hang chinh giay dep tat
        public string MainGroup { get; set; }
        // giay the thao giay công so, giay em be
        public string SubGroup { get; set; }
        public string OldImage { get; set; }
        [Required]
        public bool IsAllowComment { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
