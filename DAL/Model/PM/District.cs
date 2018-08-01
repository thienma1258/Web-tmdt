using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.PM
{
    public class District
    {
        [Key]
        public string DistrictID{get;set;}
        public string Name { get; set; }
        public string type { get; set; }
        public string location { get; set; }
        public virtual Province Province { get; set; }
    }
}
