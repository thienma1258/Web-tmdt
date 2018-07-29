using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.PM
{
   public  class Product:TrackingObject
    {
        public string Model { get; set; } = string.Empty;
        public bool isOnlineOnly { get; set; } = false;
        public int StockMin { get; set; } = 0;
        public string LadingPage { get; set; }
        public ICollection<ProductDetails> ListProductDetails { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public MainGroup MainGroup { get; set; }
        public SubGroup SubGroup { get; set; }
        #region SEO
        public string MetaKey { get; set; }
        public string MetaDescription { get; set; }
        public string UrlFriendly { get; set; }
        #endregion
    }
}
