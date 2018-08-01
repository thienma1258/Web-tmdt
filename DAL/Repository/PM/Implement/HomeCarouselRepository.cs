using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class HomeCarouselRepository : GenericRepository<HomeCarousel, string>, IHomeCarouselRepository
    {
        public HomeCarouselRepository(ShopContext context) : base(context)
        {
        }
    }
}
