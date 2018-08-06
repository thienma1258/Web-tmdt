using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class DiscoutRepository :TrackingObjectRepository<Discout>, IDiscoutRepository
    {
        public DiscoutRepository(ShopContext context) : base(context)
        {
        }
      
    }
}
