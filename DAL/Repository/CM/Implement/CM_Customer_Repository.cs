using DAL.DataContext;
using DAL.Model.CM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.CM.Implement
{
    class CM_Customer_Repository : GenericRepository<CM_Customer, string>, ICM_Customer_Repository
    {
        public CM_Customer_Repository(ShopContext context) : base(context)
        {
        }
    }
}
