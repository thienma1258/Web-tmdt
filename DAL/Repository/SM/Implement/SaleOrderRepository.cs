﻿using DAL.DataContext;
using DAL.Model.SM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.SM.Implement
{
    public class SaleOrderRepository : GenericRepository<SaleOrder, string>, ISaleOrderRepository
    {
        public SaleOrderRepository(ShopContext context) : base(context)
        {
        }
    }
}