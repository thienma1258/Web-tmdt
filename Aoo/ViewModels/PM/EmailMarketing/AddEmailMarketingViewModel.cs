using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.ViewModels.PM.EmailMarketing
{
    public class AddEmailMarketingViewModel
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<string> listEmail { get; set; }
    }
}
