using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DAL.DataContext;
using DAL.Model.PM;
namespace DAL.Repository.PM.Implement
{
    public class BrandRepository : GenericRepository<Brand, string>, IBrandRepository
    {
        public BrandRepository(ShopContext context) : base(context)
        {

        }

        

        public override void Delete(Brand entityToDelete,string DeletedUser)
        {
            entityToDelete.isDeleted = true;
            entityToDelete.DeletedDate = DateTime.Now;
            entityToDelete.DeletedUser = DeletedUser;
        }
    }
}
