using Common.Enum.SM;
using DAL.Model.CRM;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.SM
{
    public class SaleOrder:TrackingObject
    {
        public CM.CM_Customer Customer { get; set; }
        public StateConfirmEnum State { get; set; } = StateConfirmEnum.Pending;
        public TransportType TransportType { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string AuthenticationMethodGuid { get; set; }
        public decimal TransportTypePrice { get; set; }
        public Voucher Voucher { get; set; } 
        public decimal TotalPrice { get; set; }
       public int VAT { get; set; }
        public System_User ReviewBy { get; set; }
        public DateTime ReviewDate { get; set; } = DateTime.Now;
        public ICollection<SaleOrderDetail> ListSaleOrderDetails { get; set; }

    }
}
