using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ViewModel.PM
{
    public class ProductViewModel
    {
        public string idProduct { get; set; }
        public virtual BrandViewModel Brand { get; set; }
        public virtual CategoryViewModel Category { get; set; }
        public virtual MainGroupViewModel MainGroup { get; set; }
        public virtual SubGroupViewModel SubGroup { get; set; }
        public string isOnlineonly { get; set; }
        public string LandingPage { get; set; }
        public int StockMin { get; set; } 
        public int sizeProduct { get; set; }
        public string priceProduct { get; set; }
        public string defaultImages { get; set; }

    }
}
