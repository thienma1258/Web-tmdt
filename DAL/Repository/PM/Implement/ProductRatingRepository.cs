using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class ProductRatingRepository : GenericRepository<ProductRating, string>, IProductRatingRepository
    {
        public ProductRatingRepository(ShopContext context) : base(context)
        {
        }
        
    }
}
