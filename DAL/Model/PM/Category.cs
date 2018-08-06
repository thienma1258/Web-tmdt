using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.PM
{
   public class Category:SeoObject
    {
        public string Name { get; set; } = string.Empty;
        public string DefaultImage { get; set; }
        public string Description { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
