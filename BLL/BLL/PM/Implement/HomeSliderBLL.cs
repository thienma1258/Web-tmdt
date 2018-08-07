using DAL;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.PM.Implement
{
    public class HomeSliderBLL : GenericBLL, IGenericBLL<HomeSlider, string>
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
                AddError(objEx);
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
                AddError(objEx);
                return false;
            }
        }

        public async Task<IEnumerable<HomeSlider>> Get(int intNumber = -1, int currentPage = -1)
        {
            return this.unitOfWork.HomeSliderRepository.Get(filter: p => p.isDeleted == false, number: intNumber, currentPage: currentPage);
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
                AddError(objEx);
                return false;
            }
        }

        public int Cout()
        {
            throw new NotImplementedException();
        }
    }
}
