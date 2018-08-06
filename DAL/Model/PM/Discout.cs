using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.PM
{
   public class Discout:TrackingObject
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Product Product { get; set; }
        public int DiscoutRate { get; set; }
    }
}
