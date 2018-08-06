using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class HomeSliderRepository : TrackingObjectRepository<HomeSlider>, IHomeSliderRepository
    {
        public HomeSliderRepository(ShopContext context) : base(context)
        {
        }
     
    }
}
