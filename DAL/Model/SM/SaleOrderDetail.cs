using DAL.Model.CRM;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.SM
{
   public class SaleOrderDetail:TrackingObject
    {
        public  SaleOrder SaleOrder { get; set; }
        public Product Product { get; set; }
        public string Note { get; set; }
       public int Quality { get; set; }
        public decimal Price { get; set; }
        public Discout Discout { get; set; }
    }
}
