using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model
{
    public class TrackingObject
    {
        [Key]
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public bool isDeleted { get; set; } = false;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public virtual System_User CreatedUser { get; set; }
        public DateTime EditedDate { get; set; } = DateTime.Now;
        public virtual System_User EditedUser { get; set; }
        public DateTime DeletedDate { get; set; }
        public virtual System_User DeletedUser { get; set; }
    }
}
