using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class TransportTypeRepository : GenericRepository<TransportType, string>, ITransportTypeRepository
    {
        public TransportTypeRepository(ShopContext context) : base(context)
        {
        }
        public override void Delete(TransportType entityToDelete, string DeletedUser)
        {
            entityToDelete.isDeleted = true;
            entityToDelete.DeletedDate = DateTime.Now;
            entityToDelete.DeletedUser = DeletedUser;
            this.shopContext.SaveChanges();
        }
    }
}
