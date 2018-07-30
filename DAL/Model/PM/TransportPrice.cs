using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.PM
{
   public class TransportPrice:TrackingObject
    {
        public TransportType TransportType { get; set; }
        public decimal Price { get; set; }
        public District District { get; set; }
    }
}
