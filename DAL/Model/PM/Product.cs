﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.PM
{
   public  class Product:SeoObject
    {
        public string Model { get; set; } = string.Empty;
        public bool isOnlineOnly { get; set; } = false;
        public int StockMin { get; set; } = 0;
        public string DefaultImage { get; set; }
        public string Details { get; set; } = string.Empty;
        public string Specification { get; set; } = string.Empty;

        public string LadingPage { get; set; }
        public virtual ICollection<ProductDetails> ListProductDetails { get; set; }
        //adidas nike
        public virtual  Brand Brand { get; set; }
        public string BrandID { get; set; }
        public virtual Category Category { get; set; }
        public string CategoryID { get; set; }
        public decimal Price { get; set; }
        public bool IsAllowComment { get; set; }
        public string CommentArea { get; set; }
        // giay the thao giay công so, giay em be
        public virtual SubGroup SubGroup { get; set; }
        public string SubGroupID { get; set; }


    }
}
