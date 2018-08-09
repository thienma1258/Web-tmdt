using DAL.Model;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Helpers;
using System.Linq;
using System.Linq.Expressions;
using DAL;

namespace BLL.BLL.PM.Implement
{
    public class HomeCarouselBLL : GenericBLL, IHomeCarouselBLL
    {
        public HomeCarouselBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<HomeCarousel> Find(string ID)
        {
            return this.unitOfWork.HomeCarouselRepository.Find(ID);
        }
        public async Task<bool> Add(HomeCarousel homeCarousel, string CreatedUser = "adminstrator")
        {
            try
            {
                homeCarousel.CreatedUser = CreatedUser;
                this.unitOfWork.HomeCarouselRepository.Insert(homeCarousel);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }

        public async Task<bool> Delete(string entityID, string DeletedUser = "adminstrator")
        {
            try
            {
                this.unitOfWork.HomeCarouselRepository.Delete(entityID, DeletedUser);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }

     

        public async Task<bool> Update(HomeCarousel homeCarousel, string UpdatedUser = "adminstrator")
        {
            try
            {
                homeCarousel.EditedUser = UpdatedUser;
                this.unitOfWork.HomeCarouselRepository.Update(homeCarousel);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }

        public int Cout(Expression<Func<HomeCarousel, bool>> filter = null)
        {
            return this.unitOfWork.HomeCarouselRepository.Cout();
        }

        public  async Task<IEnumerable<HomeCarousel>> Get(int intNumber = -1, int currentPage = -1, Expression<Func<HomeCarousel, bool>> filter = null, Func<IQueryable<HomeCarousel>, IOrderedQueryable<HomeCarousel>> orderBy = null)
        {
            try
            {
                return unitOfWork.HomeCarouselRepository.Get(filter: filter, orderBy: orderBy, number: intNumber, currentPage: currentPage);

            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return null;
            }
        }
    }
}
