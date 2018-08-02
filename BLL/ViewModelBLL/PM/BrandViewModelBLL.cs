using Common.ViewModel.PM;
using DAL;
using DAL.Model;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ViewModelBLL
{
    public class BrandViewModelBLL
    {
        private readonly IUnitOfWork unitOfWork;
        public BrandViewModelBLL(IUnitOfWork UnitOfWork)
        {
            unitOfWork = UnitOfWork;
        }
        public async Task<bool> Delete(BrandViewModel objBrandViewModel,string DeletedUser)
        {
            try
            {
                return false;
                //Brand brand = new Brand
                //{
                //    ID = objBrandViewModel,
                //    DefaultImage = objBrandViewModel.defaultImages,
                //    Description = objBrandViewModel.defaultImages
                //};
                //this.unitOfWork.BrandRepository.Insert(brand);
                //await this.unitOfWork.SaveChangeAsync();
                //return true;
            }
            catch (Exception objEx)
            {
                ErrorLogs errorLogs = new ErrorLogs
                {
                    ErrorLog = objEx.ToString(),
                    FunctionName = MethodBase.GetCurrentMethod().ToString(),
                    ModuleName = "PM->Brand"

                };
                this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
                await this.unitOfWork.SaveChangeAsync();
                return false;
            }
        }
        public async Task<bool> Add(BrandViewModel objBrandViewModel,string CreatedUser="adminstrator")
        {
            try
            {
                Brand brand = new Brand
                {
                    Name = objBrandViewModel.nameBrand,
                    DefaultImage = objBrandViewModel.defaultImages,
                    Description = objBrandViewModel.defaultImages,
                    CreatedUser=CreatedUser
                };
                this.unitOfWork.BrandRepository.Insert(brand);
                await  this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch(Exception objEx)
            {
                ErrorLogs errorLogs = new ErrorLogs
                {
                    ErrorLog = objEx.ToString(),
                    FunctionName = MethodBase.GetCurrentMethod().ToString(),
                    ModuleName = "PM->Brand"

                };
                this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
                await this.unitOfWork.SaveChangeAsync();
                return false;
            }
        }

        public  List<BrandViewModel> Get(int intNumber,int intSkippage)
        {

            var listBrand=this.unitOfWork.BrandRepository.Get(filter:p=>p.isDeleted==false,number: intNumber,skippage:intSkippage);
            var listBrandViewModel = new List<BrandViewModel>();
            foreach (var Brand in listBrand)
            {
                BrandViewModel objBrandViewModel = new BrandViewModel
                {
                    defaultImages = Brand.DefaultImage,
                    nameBrand = Brand.Name,
                    Description = Brand.Description
                };
                listBrandViewModel.Add(objBrandViewModel);
            }
            return listBrandViewModel;
        }
        public async Task<bool> Update(BrandViewModel objBrandViewModel, string DeletedUser)
        {
            try
            {
                return false;
                //Brand brand = new Brand
                //{
                //    ID = objBrandViewModel,
                //    DefaultImage = objBrandViewModel.defaultImages,
                //    Description = objBrandViewModel.defaultImages
                //};
                //this.unitOfWork.BrandRepository.Insert(brand);
                //await this.unitOfWork.SaveChangeAsync();
                //return true;
            }
            catch (Exception objEx)
            {
                ErrorLogs errorLogs = new ErrorLogs
                {
                    ErrorLog = objEx.ToString(),
                    FunctionName = MethodBase.GetCurrentMethod().ToString(),
                    ModuleName = "PM->Brand"

                };
                this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
                await this.unitOfWork.SaveChangeAsync();
                return false;
            }
        }
    }
}
