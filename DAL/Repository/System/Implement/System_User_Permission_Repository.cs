using DAL.DataContext;
using DAL.Model.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.System.Implement
{
    public class System_User_Permission_Repository : TrackingObjectRepository<System_User_Permission>, ISystem_User_Permission_Repository
    {
        public System_User_Permission_Repository(ShopContext context) : base(context)
        {
        }
        
    }
}
