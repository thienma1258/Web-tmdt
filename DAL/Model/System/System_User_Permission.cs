using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.System
{
    public class System_User_Permission:TrackingObject
    {
        public virtual System_User User { get; set; }
        public string UserID { get; set; }

        public string UserPermission { get; set; }
        public string UserPermissionValue { get; set; }
        public virtual System_User ReviewUser { get; set; }
        public virtual string ReviewUserID { get; set; }

        public virtual DateTime ReviewDate { get; set; } = DateTime.Now;
    }
}
