using Common.Enum.SM;
using DAL.Model.CRM;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.SM
{
    public class SaleOrder:TrackingObject
    {
        public string CustomerID { get; set; }
        public virtual CM.CM_Customer Customer { get; set; }
        public StateConfirmEnum State { get; set; } = StateConfirmEnum.Pending;
        [Display(Name = "Nhà vận chuyển")]
        public virtual TransportType TransportPrice { get; set; }
        public string TransportPriceID { get; set; }
        [Display(Name = "Phí vận chuyển")]
        public decimal CurrentTransportPrice{ get; set; }
        [Display(Name = "Phương thức thanh toán")]
        public PaymentMethod PaymentMethod { get; set; }
        public string AuthenticationMethodGuid { get; set; }
        public decimal TransportTypePrice { get; set; }
        public virtual Voucher Voucher { get; set; }
        public string VoucherID { get; set; }
        [Display(Name = "Tổng tiền")]
        public decimal TotalPrice { get; set; }
        [Display(Name = "Đã trả tiền chưa")]
        public bool IsPay { get; set; } = false;
        public int VAT { get; set; }
        [Display(Name = "Người xác nhận")]
        public string  ReviewBy { get; set; }
        public DateTime ReviewDate { get; set; } 
        public virtual ICollection<SaleOrderDetail> ListSaleOrderDetails { get; set; }

    }
}
