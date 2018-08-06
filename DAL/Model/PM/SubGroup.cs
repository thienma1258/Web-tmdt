using Common.Enum.PM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Model.PM
{
    public class SubGroup:SeoObject
    {
        public string Name { get; set; } = string.Empty;
        public string DefaultImage { get; set; }
        public string Description { get; set; } = string.Empty;
        
        public TypeSexEnum TypeSex { get; set; } = TypeSexEnum.All;
        public virtual MainGroup MainGroup { get; set; }
    
    }
}
