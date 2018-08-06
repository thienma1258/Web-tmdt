using DAL.Model.System;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Model
{
    public class System_User : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName { get { return LastName + FirstName; } }
        public string CMND { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual System_Position Position {get;set;}
        public string PositionID { get; set; }
        public virtual IEnumerable<System_User_Permission> System_User_Permissions { get; set; }

    }
}
