using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.Helpers
{
    public static class ViewHelpers
    {
        public static int TotalPage(int totalCout,int numberPerPage)
        {
            int page = totalCout / numberPerPage;
            if (totalCout % numberPerPage != 0)
                page++;
            return page;
        }
        public static int NumberPerPageFront { get; set; } = 9;


    }
}
