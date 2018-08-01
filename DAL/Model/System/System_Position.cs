using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.System
{
    public class System_Position:TrackingObject
    {
        public string NamePosition { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public virtual ICollection<System_User> List_Position_Users { get; set; }
    }
}
