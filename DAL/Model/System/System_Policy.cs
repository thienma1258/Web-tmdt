using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.System
{
   public class System_Policy
    {
        public System_User User { get; set; }
        public string UserPolicy { get; set; }
        public string UserPolicyValue { get; set; }
        public System_User RerviewUser { get; set; }
        public DateTime ReviewDate { get; set; } = DateTime.Now;
    }
}
