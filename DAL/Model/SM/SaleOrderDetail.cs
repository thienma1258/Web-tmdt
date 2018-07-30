using DAL.Model.CRM;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.SM
{
   public class SaleOrderDetail:TrackingObject
    {
        public virtual SaleOrder SaleOrder { get; set; }
        public virtual Product Product { get; set; }
        public string Note { get; set; }
       public int Quality { get; set; }
        public decimal Price { get; set; }
        public virtual Discout Discout { get; set; }
    }
}
