using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.BLL.Log;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Aoo.Controllers.Admin.Log
{
    [Authorize]
    [Route("ErrorLog")]
    [Area("Log")]
    public class ErrorLogsController : BaseController
    {
        IErrorLogsBLL errorLogsBLL;
        public ErrorLogsController(IImageServices imageServices,IErrorLogsBLL errorLogs ) : base(imageServices)
        {
            this.errorLogsBLL = errorLogs;
        }
        [Route("")]
        public   IActionResult Index(string SearchText="")
        {

            return View(this.errorLogsBLL.Get(p=>p.FunctionName.Contains(SearchText)||p.ModuleName.Contains(SearchText)));
        }
        [Route("DeleteAll")]
        public IActionResult DeleteAll()
        {
            if(this.errorLogsBLL.DeleteAll())
            return RedirectToAction("Index");
            return Redirect("/Error");
        }
        public IActionResult Details(string ID)
        {
            return View(this.errorLogsBLL.Find(ID));
        }
    }
    
}