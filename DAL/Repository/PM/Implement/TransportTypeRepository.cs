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
    }
}
