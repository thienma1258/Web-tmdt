using DAL;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.PM.Implement
{
    public class CategoryBLL : GenericBLL, IGenericBLL<Category,string>
    {
        public CategoryBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public async Task<Category> Find(string ID)
        {
            return this.unitOfWork.CategoryRepository.Find(ID);
        }
        public Task<bool> Add(Category entity, string CreatedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string entityID, string DeletedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> Get(int intNumber = -1, int intSkippage = -1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Category entity, string UpdatedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }
    }
}
