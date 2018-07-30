using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.System
{
   public class System_Policy
    {
        public virtual System_User User { get; set; }
        public string UserPolicy { get; set; }
        public string UserPolicyValue { get; set; }
        public virtual System_User RerviewUser { get; set; }
        public virtual DateTime ReviewDate { get; set; } = DateTime.Now;
    }
}
