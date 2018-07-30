using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.PM
{
    public class District
    {
        [Key]
        public int DistrictID{get;set;}
        public string DistrictName { get; set; }
        public Province province { get; set; }
    }
}
