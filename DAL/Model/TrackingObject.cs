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
        public string  CreatedUser { get; set; }
        public DateTime EditedDate { get; set; } = DateTime.Now;
        public string  EditedUser { get; set; }
        public DateTime DeletedDate { get; set; }
        public string  DeletedUser { get; set; }
    }
}
