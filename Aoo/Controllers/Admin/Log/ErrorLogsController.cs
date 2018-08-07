using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.BLL.Log;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Aoo.Controllers.Admin.Log
{
    [Route("[controller]/[action]")]
    [Area("Log")]
    public class ErrorLogsController : BaseController
    {
        IErrorLogsBLL errorLogsBLL;
        public ErrorLogsController(IImageServices imageServices,IErrorLogsBLL errorLogs ) : base(imageServices)
        {
            this.errorLogsBLL = errorLogs;
        }

        public   IActionResult Index(string SearchText)
        {
            return View(this.errorLogsBLL.Get(p=>p.FunctionName.Contains(SearchText)||p.ModuleName.Contains(SearchText)));
        }

        public IActionResult DeleteAll()
        {
            if(this.errorLogsBLL.DeleteAll())
            return RedirectToAction("Index");
            return Redirect("/Error");
        }
    }
}