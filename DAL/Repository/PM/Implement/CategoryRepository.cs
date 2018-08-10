using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.PM.Implement
{
    public class CategoryRepository : SeoRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ShopContext context) : base(context)
        {
        }

        public Task<Category> SearchByUrl(string url)
        {
            throw new NotImplementedException();
        }
    }
}
