using DAL.DataContext;
using DAL.Model.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.System.Implement
{
    public class System_Policy_Repository :TrackingObjectRepository<System_Policy>, ISystem_Policy_Repository
    {
        public System_Policy_Repository(ShopContext context) : base(context)
        {
        }
       
    }
}
