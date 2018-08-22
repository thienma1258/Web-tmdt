using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.ViewModels
{
    public class LoadSaleDetailsModel
    {
        public string IDsaleOrder { get; set; }
        public string IDCus { get; set; }
        public List<string> IDsaleDetails { get; set; }
        public string PhoneCus { get; set; }
        public string CMND { get; set; }
        public string NameCus { get; set; }
        public string AdressDev { get; set; }
        public string ModelName { get; set; }
        public string Color { get; set; }
        public decimal PricePro { get; set; }
        public int QuantityPro { get; set; }
    }
}