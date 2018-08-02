using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class ProductRepository : GenericRepository<Product, string>, IProductRepository
    {
        public ProductRepository(ShopContext context) : base(context)
        {
        }
        public override void Delete(Product entityToDelete,string DeletedUser="adminstrator")
        {
            entityToDelete.isDeleted = true;
            entityToDelete.DeletedDate = DateTime.Now;
            entityToDelete.DeletedUser = DeletedUser;
        }
    }
}
