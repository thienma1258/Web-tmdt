using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL.DataContext;
using DAL.Model.PM;
namespace DAL.Repository.PM.Implement
{
    public class BrandRepository :SeoRepository<Brand>, IBrandRepository
    {
        public BrandRepository(ShopContext context) : base(context)
        {

        }

        public async Task<Brand> SearchByUrl(string url)
        {
            return null;
        }
    }
}
