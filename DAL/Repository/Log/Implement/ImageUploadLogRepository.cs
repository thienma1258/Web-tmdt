using DAL.DataContext;
using DAL.Model.Log;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.Log.Implement
{
    internal class ImageUploadLogRepository : GenericRepository<ImageUploadLog, string>, IImageUploadLogRepository
    {
        public ImageUploadLogRepository(ShopContext context) : base(context)
        {
        }
    }
}
