﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.PM
{
    public class Province
    {
        [Key]
        public string  ProvinceID { get; set; }
        public string Name { get; set; }
        public string type { get; set; }
        
        public virtual ICollection<District> Districts { get; set; }
    }
}
