using DAL.Model.PM;
using DAL.Model.SM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.PM
{
   public class Discout:TrackingObject
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string ProductID { get; set; }
        public Product Product { get; set; }
        public int DiscoutRate { get; set; }
        public bool IsUsed { get; set; }
        public IEnumerable<SaleOrderDetail> SaleOrderDetails { get; set; }
    }
}
