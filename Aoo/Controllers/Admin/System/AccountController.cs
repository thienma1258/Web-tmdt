using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.BLL.System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Aoo.Controllers.Admin.System
{
    [Route("Admin/[action]")]
    [Area("System")]
    public class AccountController : BaseController
    {
        public IUserBLL UserBLL;
        public AccountController(IUserBLL UserBLL,IImageServices imageServices) : base(imageServices)
        {
            this.UserBLL = UserBLL;
        }

         
        public IActionResult Login()
        {
            
                return View();
           
        }

        public async  Task<string> InitiliseAccout()
        {
            DAL.Model.System_User _User = new DAL.Model.System_User
            {
                FirstName = "Nobody",
                UserName = "adminstrator",
                LastName = "Mr",
                DateOfBirth = new DateTime(1997, 10, 2),
                Email = "cpud1258@gmail.com",

            };
           await  this.UserBLL.Add(_User, "9406715", "adminstrator");
            if (UserBLL.IdentityResult == IdentityResult.Success)
            {
                return "Create accout admin success";
            }
            else return UserBLL.IdentityResult.Errors.ToString();
        }
        [HttpPost]
        public IActionResult Login(Aoo.Models.AccountViewModels.LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
    }
}