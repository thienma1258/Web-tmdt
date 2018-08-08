using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.System
{
    public class System_User_Permission:TrackingObject
    {
        public string UserName { get; set; }
        public System_Permission System_Permission { get; set; }
        public virtual string System_PermissionID { get; set; }
        public virtual string ReviewUserName { get; set; }
        public virtual DateTime ReviewDate { get; set; } = DateTime.Now;
    }
}
