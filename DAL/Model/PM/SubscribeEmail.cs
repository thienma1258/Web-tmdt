using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.PM
{
   public class SubscribeEmail
    {
        [Key]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;

    }
}
