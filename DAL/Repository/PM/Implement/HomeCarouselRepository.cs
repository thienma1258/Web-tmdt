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
        public override void Delete(HomeCarousel entityToDelete,string DeletedUser)
        {
            entityToDelete.isDeleted = true;
            entityToDelete.DeletedDate = DateTime.Now;
            entityToDelete.DeletedUser = DeletedUser;
        }
    }
}
