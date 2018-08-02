using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class HomeSliderRepository : GenericRepository<HomeSlider, string>, IHomeSliderRepository
    {
        public HomeSliderRepository(ShopContext context) : base(context)
        {
        }
        public override void Delete(HomeSlider entityToDelete,string DeletedUser)
        {
            entityToDelete.isDeleted = true;
            entityToDelete.DeletedDate = DateTime.Now;
            entityToDelete.DeletedUser = DeletedUser;
            this.shopContext.SaveChanges();
        }
    }
}
