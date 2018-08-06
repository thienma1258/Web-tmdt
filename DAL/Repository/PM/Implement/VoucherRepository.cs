﻿using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class VoucherRepository : TrackingObjectRepository<Voucher>, IVoucherRepository
    {
        public VoucherRepository(ShopContext context) : base(context)
        {
        }
       
    }
}
