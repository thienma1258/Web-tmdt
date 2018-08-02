using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class CategoryRepository : GenericRepository<Category, string>, ICategoryRepository
    {
        public CategoryRepository(ShopContext context) : base(context)
        {
        }
        public override void Delete(Category entityToDelete,string DeletedUser = "adminstrator")
        {
            entityToDelete.isDeleted = true;
            entityToDelete.DeletedUser = DeletedUser;
            entityToDelete.DeletedDate = DateTime.Now;
        }
    }
}
