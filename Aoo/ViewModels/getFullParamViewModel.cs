using Aoo.ViewModels.CM;
using Aoo.ViewModels.SM;
using DAL.Model.CM;
using DAL.Model.SM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.ViewModels
{
    public class getFullParamViewModel
    {
        public SaleOrderInfoViewModel saleOrder { get; set; }
        public List<SaleOrderDetailsViewModel> saleOrderDetails { get; set; }
        public CustomerViewModel Customer { get; set; }
    }
}
