using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.ViewModels.SM
{
    public class SaleOrderInfoViewModel
    {
        public string TransportPriceID { get; set; }
        public string TransportTypeID { get; set; }
        public decimal TotalPrice { get; set; }
        public string ReceiveAddress { get; set; }
        public int PaymentMethod { get; set; }
        public string DistrictID { get; set; }
    }
}
