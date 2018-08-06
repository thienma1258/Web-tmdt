using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class ProductDetailsRepository :TrackingObjectRepository<ProductDetails>, IProductDetailsRepository
    {
        public ProductDetailsRepository(ShopContext context) : base(context)
        {
        }

     
    }
}
