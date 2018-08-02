using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class MainGroupRepository : GenericRepository<MainGroup, string>, IMainGroupRepository
    {
        public MainGroupRepository(ShopContext context) : base(context)
        {
        }
        public override void Delete(MainGroup entityToDelete,string DeletedUser)
        {
            entityToDelete.isDeleted = true;
            entityToDelete.DeletedDate = DateTime.Now;
            entityToDelete.DeletedUser = DeletedUser;
        }
    }
}
