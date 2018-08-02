using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class DiscoutRepository : GenericRepository<Discout, string>, IDiscoutRepository
    {
        public DiscoutRepository(ShopContext context) : base(context)
        {
        }
        public override void Delete(Discout entityToDelete,string DeletedUser)
        {
            entityToDelete.isDeleted = true;
            entityToDelete.DeletedDate = DateTime.Now;
            entityToDelete.DeletedUser = DeletedUser;
        }
    }
}
