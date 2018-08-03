using DAL.DataContext;
using DAL.Model.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.System.Implement
{
    public class System_User_Permission_Repository : GenericRepository<System_User_Permission, string>, ISystem_User_Permission_Repository
    {
        public System_User_Permission_Repository(ShopContext context) : base(context)
        {
        }
        public override void Delete(System_User_Permission entityToDelete, string DeletedUser)
        {
            entityToDelete.isDeleted = true;
            entityToDelete.DeletedDate = DateTime.Now;
            entityToDelete.DeletedUser = DeletedUser;
        }
    }
}
