using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class TransportPriceRepository : GenericRepository<TransportPrice, string>, ITransportPriceRepository
    {
        public TransportPriceRepository(ShopContext context) : base(context)
        {
        }
    }
}
