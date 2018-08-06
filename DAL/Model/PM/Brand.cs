using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.PM
{
    public class Brand:SeoObject
    {
     
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string DefaultImage { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }

       
    }
}
