using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aoo.Models.AccountViewModels;
using BLL.BLL.System;
using Microsoft.AspNetCore.Authorization;
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
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var IsSuccess = await UserBLL.SignIn(model.Username, model.Password, model.RememberMe);
                if (!IsSuccess)
                {
                    ModelState.AddModelError(string.Empty, "Username or Password doesn't correct");
                    return View();
                }

                var result = UserBLL.SignInResult;
                if (result.Succeeded)
                {
                    return Redirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                   // return RedirectToAction(nameof(LoginWith2fa), new { returnUrl, model.RememberMe });
                }
                if (result.IsLockedOut)
                {
                 //   _logger.LogWarning("User account locked out.");
               //     return RedirectToAction(nameof(Lockout));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }
            }
            return View();
        }
    }
}