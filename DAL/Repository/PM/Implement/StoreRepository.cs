using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class StoreRepository : GenericRepository<Store, string>, IStoreRepository
    {
        public StoreRepository(ShopContext context) : base(context)
        {
            
        }
        public override void Delete(Store entityToDelete,string DeletedUser)
        {
            entityToDelete.isDeleted = true;
            entityToDelete.DeletedDate = DateTime.Now;
            entityToDelete.DeletedUser = DeletedUser;
        }
    }
}
