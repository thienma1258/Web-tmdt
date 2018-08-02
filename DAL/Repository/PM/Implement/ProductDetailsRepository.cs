using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class ProductDetailsRepository : GenericRepository<ProductDetails, string>, IProductDetailsRepository
    {
        public ProductDetailsRepository(ShopContext context) : base(context)
        {
        }

        public override void Delete(ProductDetails entityToDelete,string DeletedUser)
        {
            entityToDelete.isDeleted = true;
            entityToDelete.DeletedDate = DateTime.Now;
            entityToDelete.DeletedUser = DeletedUser;
        }
    }
}
