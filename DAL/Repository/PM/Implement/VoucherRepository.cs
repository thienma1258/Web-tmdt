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
        public override void Delete(Voucher entityToDelete, string DeletedUser)
        {
            entityToDelete.isDeleted = true;
            entityToDelete.DeletedDate = DateTime.Now;
            entityToDelete.DeletedUser = DeletedUser;
        }
    }
}
