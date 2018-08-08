using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Model.System
{
    public class System_Permission:TrackingObject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string PermissionCode { get; set; }
        public string PermissionName { get; set; }
        public virtual IEnumerable<System_User_Permission> System_User_Permissions { get; set; }
    }
}
