using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.PM
{
    public class ProductRating
    {
        public Product Product { get; set; }
        public float RateStar { get; set; } = 0;
        public string IpAddress { get; set; } = string.Empty;
        public DateTime CreatedTime { get; set; } = DateTime.Now;

    }
}
