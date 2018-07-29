﻿using DAL.Enum.PM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DAL.Model.PM
{
    public class ProductDetails:TrackingObject
    {
        public TypeColorEnum TypeColor { get; set; }
        public int Size { get; set; } = 0;
        public Product Product { get; set; }
        public string Specification { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Details { get; set; } = string.Empty;
      
        public int Quality { get; set; }
        public int StockMin { get; set; }
        public int MaxQualityBuy { get; set; }
        [Column]
        private String listImages { get; set; }
        [NotMapped]
        public List<String> ListImages
        {
            get { return listImages.Split(',').ToList(); }
            set
            {
                listImages = String.Join(",", value);
            }
        }

        

    }
}