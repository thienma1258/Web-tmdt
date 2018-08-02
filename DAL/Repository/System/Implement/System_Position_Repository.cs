using DAL.DataContext;
using DAL.Model.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.System.Implement
{
    public class System_Position_Repository : GenericRepository<System_Position, string>, ISystem_Position_Repository
    {
        public System_Position_Repository(ShopContext context) : base(context)
        {
        }
        public override void Delete(System_Position entityToDelete, string DeletedUser)
        {
            entityToDelete.isDeleted = true;
            entityToDelete.DeletedDate = DateTime.Now;
            entityToDelete.DeletedUser = DeletedUser;
        }
    }
}
