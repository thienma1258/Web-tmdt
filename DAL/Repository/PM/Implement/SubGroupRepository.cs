using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.PM.Implement
{
    public class SubGroupRepository : SeoRepository<SubGroup>, ISubGroupRepository
    {
        public SubGroupRepository(ShopContext context) : base(context)
        {
        }

        public Task<SubGroup> SearchByUrl(string url)
        {
            throw new NotImplementedException();
        }
    }
}
