using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.PM
{
   public class TransportPrice:TrackingObject
    {
        public string TransportTypeID { get; set; }
        public TransportType TransportType { get; set; }
        public decimal Price { get; set; }
        public virtual District District { get; set; }
        public string  DistrictID { get; set; }

    }
}
