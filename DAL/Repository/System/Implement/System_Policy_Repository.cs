using DAL.DataContext;
using DAL.Model.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.System.Implement
{
    public class System_Policy_Repository : GenericRepository<System_Policy, string>, ISystem_Policy_Repository
    {
        public System_Policy_Repository(ShopContext context) : base(context)
        {
        }
        public override void Delete(System_Policy entityToDelete, string DeletedUser)
        {
            entityToDelete.isDeleted = true;
            entityToDelete.DeletedDate = DateTime.Now;
            entityToDelete.DeletedUser = DeletedUser;
        }
    }
}
