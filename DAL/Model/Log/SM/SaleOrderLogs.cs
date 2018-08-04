using Common.Enum.SM;
using DAL.Model.PM;
using DAL.Model.SM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.Log
{
    public class SaleOrderLogs
    {
        public string LogsSaleOrder { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public virtual CM.CM_Customer Customer { get; set; }
        public StateConfirmEnum State { get; set; } = StateConfirmEnum.Pending;
        public decimal TransportTypePrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string AuthenticationMethodGuid { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsPay { get; set; } = false;
        public int VAT { get; set; }
        public string ReviewBy { get; set; }
        public DateTime ReviewDate { get; set; } = DateTime.Now;
        public string Logs { get; set; }

    }
}
