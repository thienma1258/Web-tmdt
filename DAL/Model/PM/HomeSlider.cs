using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.PM
{
   public class HomeSlider:TrackingObject
    {
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public int OrderIndex { get; set; }
        
    }
}
