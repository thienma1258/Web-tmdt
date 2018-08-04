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
        public virtual CM.CM_Customer Customer { get; set; }
        public StateConfirmEnum State { get; set; } = StateConfirmEnum.Pending;
        public virtual TransportPrice TransportPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string AuthenticationMethodGuid { get; set; }
        public decimal TransportTypePrice { get; set; }
        public virtual Voucher Voucher { get; set; } 
        public decimal TotalPrice { get; set; }
        public bool IsPay { get; set; } = false;
        public int VAT { get; set; }
        public string  ReviewBy { get; set; }
        public DateTime ReviewDate { get; set; } = DateTime.Now;
        public virtual ICollection<SaleOrderDetail> ListSaleOrderDetails { get; set; }

    }
}
