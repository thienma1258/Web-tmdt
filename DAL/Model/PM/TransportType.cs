using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.PM
{
   public class TransportType:TrackingObject
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int Prestige { get; set; }
        public string Note { get; set; }
        public IEnumerable<TransportPrice> TransportPrices { get; set; }
        
    }
}
