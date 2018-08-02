using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class VoucherRepository : GenericRepository<Voucher, string>, IVoucherRepository
    {
        public VoucherRepository(ShopContext context) : base(context)
        {
        }
    }
}
