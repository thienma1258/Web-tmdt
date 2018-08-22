using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.BLL.CM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aoo.Controllers.Admin.CM
{
    [Authorize]
    [Route("[controller]/[action]")]
    [Area("CM")]
    public class CustomerController : BaseController
    {
        public ICustomerBLL customerBLL;

        public CustomerController(ICustomerBLL customerBLL)
        {
            this.customerBLL = customerBLL;
        }

        public async Task<IActionResult> Index(int page = 1, string Search = null)
        {
            IEnumerable<DAL.Model.CM.CM_Customer> listCustomer = await customerBLL.Get(currentPage: page, intNumber: numberPerPage, filter: p => (Search == null || p.CustomerName.Contains(Search) || p.PhoneNumber.Contains(Search)));
            ViewBag.currentPage = page;
            ViewBag.totalPage =TotalPage(customerBLL.Cout(p =>(Search==null|| p.CustomerName.Contains(Search) || p.PhoneNumber.Contains(Search))));
            return View(listCustomer);
        }
    }
}