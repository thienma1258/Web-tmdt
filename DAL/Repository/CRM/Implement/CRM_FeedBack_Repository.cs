using DAL.DataContext;
using DAL.Model.CRM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.CRM.Implement
{
    class CRM_FeedBack_Repository : GenericRepository<CRM_FeedBack, string>, ICRM_FeedBack_Repository
    {
        public CRM_FeedBack_Repository(ShopContext context) : base(context)
        {
        }
       
    }
}
