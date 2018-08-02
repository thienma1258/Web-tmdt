using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class ProvinceRepository : GenericRepository<Province, string>, IProvinceRepository
    {
        public ProvinceRepository(ShopContext context) : base(context)
        {
        }
    }
}
