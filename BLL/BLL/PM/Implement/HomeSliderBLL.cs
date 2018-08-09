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
using Services.ImageServices;

namespace BLL.BLL.PM.Implement
{
    public class HomeSliderBLL : GenericBLL, IHomeSliderBLL
        
    {
        public HomeSliderBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<HomeSlider> Find(string ID)
        {
            return this.unitOfWork.HomeSliderRepository.Find(ID);
        }
        public async Task<bool> Add(HomeSlider homeSlider, string CreatedUser = "adminstrator")
        {
            try
            {
                homeSlider.CreatedUser = CreatedUser;
                this.unitOfWork.HomeSliderRepository.Insert(homeSlider);
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
                this.unitOfWork.HomeSliderRepository.Delete(entityID, DeletedUser);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }
        private string UploadImage(string imagePath, ref ImageErrorModel imageErrorModel)
        {
            throw new NotImplementedException();
        }


        public async Task<bool> Update(HomeSlider homeSlider, string UpdatedUser = "adminstrator")
        {
            try
            {
                homeSlider.EditedUser = UpdatedUser;
                this.unitOfWork.HomeSliderRepository.Update(homeSlider);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }

        public int Cout(Expression<Func<HomeSlider, bool>> filter = null)
        {
       
            return this.unitOfWork.HomeSliderRepository.Cout();
        }

        public async Task<IEnumerable<HomeSlider>> Get(int intNumber = -1, int currentPage = -1, Expression<Func<HomeSlider, bool>> filter = null, Func<IQueryable<HomeSlider>, IOrderedQueryable<HomeSlider>> orderBy = null)
        {
            try
            {
                return unitOfWork.HomeSliderRepository.Get(filter: filter, orderBy: orderBy, number: intNumber, currentPage: currentPage);

            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return null;
            }
        }
    }
}
