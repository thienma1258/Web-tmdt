﻿using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class TransportTypeRepository : TrackingObjectRepository<TransportType>, ITransportTypeRepository
    {
        public TransportTypeRepository(ShopContext context) : base(context)
        {
        }

       
    }
}
