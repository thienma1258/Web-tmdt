using DAL;
using DAL.Model;
using DAL.Model.PM;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.PM
{
    public class MainGroupBLL : GenericBLL, IMainGroupBLL
    {
        public MainGroupBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<MainGroup> Find(string ID)
        {
            return this.unitOfWork.MainGroupRepository.Find(ID);
        }
        public async Task<bool> Update(MainGroup MainGroup, string UpdatedUser = "adminstrator")
        {
            try
            {
                MainGroup.EditedUser = UpdatedUser;
                MainGroup.UrlFriendly = MainGroup.Name.UrlFriendLy();
                this.unitOfWork.MainGroupRepository.Update(MainGroup);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }
        public async Task<bool> Delete(string MainGroupID, string DeletedUser = "adminstrator")
        {
            try
            {
                this.unitOfWork.MainGroupRepository.Delete(MainGroupID, DeletedUser);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }
        public async Task<bool> Add(MainGroup MainGroup, string CreatedUser = "adminstrator")
        {
            try
            {
                MainGroup.CreatedUser = CreatedUser;
                this.unitOfWork.MainGroupRepository.Insert(MainGroup);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }

        public async Task<IEnumerable<MainGroup>> Get(int intNumber = -1, int currentPage = -1, Expression<Func<MainGroup, bool>> filter = null, Func<IQueryable<MainGroup>, IOrderedQueryable<MainGroup>> orderBy = null)
        {
            try
            {
                return unitOfWork.MainGroupRepository.Get(filter: filter, orderBy: orderBy, number: intNumber, currentPage: currentPage);

            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return null;
            }
        }


        public int Cout(Expression<Func<MainGroup, bool>> filter = null)
        {
            return this.unitOfWork.MainGroupRepository.Cout(filter);
        }

        public MainGroup SearchByUrl(string url)
        {
            return this.SearchByUrl(url);
        }
    }
}
