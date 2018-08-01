using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.System
{
   public class System_Policy:TrackingObject
    {
        public virtual System_Position System_Position { get; set; }
        public string System_Position_Policy { get; set; }
        public string System_Position_Policy_Value { get; set; }
        public virtual System_User ReviewUser { get; set; }
        public virtual DateTime ReviewDate { get; set; } = DateTime.Now;
    }
}
