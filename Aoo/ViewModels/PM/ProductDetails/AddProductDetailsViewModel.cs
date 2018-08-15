using Common.Enum.PM;
using DAL.Model.PM;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.ViewModels.PM.ProductDetails
{
    public class AddProductDetailsViewModel
    {
        public TypeColorEnum TypeColor { get; set; }
        public int Size { get; set; } = 0;
        public string Product { get; set; }
        public string Specification { get; set; } 
        public string Note { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public List<IFormFile> ListDefaultImage { get; set; }
        public int Quantity { get; set; }
        public int StockMin { get; set; }
        public int MaxQuantityBuy { get; set; }
    }
}
